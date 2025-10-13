using Microsoft.AspNetCore.Mvc;
using Data;
using Models;

namespace Controllers;

[ApiController]
[Route("api/[controller]")]
public class ScenariosController : ControllerBase
{
    private readonly InMemoryDb _db;
    public ScenariosController(InMemoryDb db) => _db = db;

    [HttpGet] public ActionResult<IEnumerable<Scenario>> Get() => _db.Scenarios;

    [HttpGet("{id:int}")]
    public ActionResult<Scenario> GetById(int id)
        => _db.Scenarios.FirstOrDefault(s => s.Id == id) is { } s ? Ok(s) : NotFound();

    [HttpPost]
    public ActionResult<Scenario> Create([FromBody] Scenario input)
    {
        if (!ModelState.IsValid) return ValidationProblem(ModelState);
        if (!_db.Rooms.Any(r => r.Id == input.RoomId))
            return BadRequest(new { error = "RoomId does not exist." });

        input.Id = _db.NewScenarioId();
        _db.Scenarios.Add(input);
        return CreatedAtAction(nameof(GetById), new { id = input.Id }, input);
    }

    [HttpPut("{id:int}")]
    public ActionResult<Scenario> Update(int id, [FromBody] Scenario input)
    {
        if (!ModelState.IsValid) return ValidationProblem(ModelState);
        var idx = _db.Scenarios.FindIndex(s => s.Id == id);
        if (idx < 0) return NotFound();
        if (!_db.Rooms.Any(r => r.Id == input.RoomId))
            return BadRequest(new { error = "RoomId does not exist." });

        input.Id = id;
        _db.Scenarios[idx] = input;
        return Ok(input);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var s = _db.Scenarios.FirstOrDefault(x => x.Id == id);
        if (s is null) return NotFound();
        _db.Scenarios.Remove(s);
        return NoContent();
    }
}
