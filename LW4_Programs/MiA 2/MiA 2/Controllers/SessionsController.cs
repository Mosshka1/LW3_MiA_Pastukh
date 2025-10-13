using Microsoft.AspNetCore.Mvc;
using Data;
using Models;

namespace Controllers;

[ApiController]
[Route("api/[controller]")]
public class SessionsController : ControllerBase
{
    private readonly InMemoryDb _db;
    public SessionsController(InMemoryDb db) => _db = db;

    [HttpGet] public ActionResult<IEnumerable<GameSession>> Get() => _db.Sessions;

    [HttpGet("{id:int}")]
    public ActionResult<GameSession> GetById(int id)
        => _db.Sessions.FirstOrDefault(s => s.Id == id) is { } s ? Ok(s) : NotFound();

    [HttpPost]
    public ActionResult<GameSession> Create([FromBody] GameSession input)
    {
        if (!ModelState.IsValid) return ValidationProblem(ModelState);
        if (!_db.Bookings.Any(b => b.Id == input.BookingId && b.Approved))
            return BadRequest(new { error = "BookingId must exist and be approved." });

        input.Id = _db.NewSessionId();
        input.Status = SessionStatus.Scheduled;
        _db.Sessions.Add(input);
        return CreatedAtAction(nameof(GetById), new { id = input.Id }, input);
    }

    [HttpPatch("{id:int}/status")]
    public ActionResult<GameSession> SetStatus(int id, [FromBody] SessionStatus status)
    {
        var idx = _db.Sessions.FindIndex(s => s.Id == id);
        if (idx < 0) return NotFound();
        var s = _db.Sessions[idx]; s.Status = status; _db.Sessions[idx] = s;
        return Ok(s);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var s = _db.Sessions.FirstOrDefault(x => x.Id == id);
        if (s is null) return NotFound();
        _db.Sessions.Remove(s);
        return NoContent();
    }
}
