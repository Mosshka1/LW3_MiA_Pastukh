using Microsoft.AspNetCore.Mvc;
using Data;
using Models;

namespace Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoomsController : ControllerBase
{
    private readonly InMemoryDb _db;
    public RoomsController(InMemoryDb db) => _db = db;

    [HttpGet] public ActionResult<IEnumerable<Room>> Get() => _db.Rooms;

    [HttpGet("{id:int}")]
    public ActionResult<Room> GetById(int id)
        => _db.Rooms.FirstOrDefault(r => r.Id == id) is { } r ? Ok(r) : NotFound();

    [HttpPost]
    public ActionResult<Room> Create([FromBody] Room input)
    {
        if (!ModelState.IsValid) return ValidationProblem(ModelState);
        input.Id = _db.NewRoomId();
        _db.Rooms.Add(input);
        return CreatedAtAction(nameof(GetById), new { id = input.Id }, input);
    }

    [HttpPut("{id:int}")]
    public ActionResult<Room> Update(int id, [FromBody] Room input)
    {
        if (!ModelState.IsValid) return ValidationProblem(ModelState);
        var idx = _db.Rooms.FindIndex(r => r.Id == id);
        if (idx < 0) return NotFound();
        input.Id = id;
        _db.Rooms[idx] = input;
        return Ok(input);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var r = _db.Rooms.FirstOrDefault(x => x.Id == id);
        if (r is null) return NotFound();
        _db.Scenarios.RemoveAll(s => s.RoomId == id);
        _db.Bookings.RemoveAll(b => b.RoomId == id);
        _db.Rooms.Remove(r);
        return NoContent();
    }
}
