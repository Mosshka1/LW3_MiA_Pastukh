using Microsoft.AspNetCore.Mvc;
using Data;
using Models;

namespace Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingsController : ControllerBase
{
    private readonly InMemoryDb _db;
    public BookingsController(InMemoryDb db) => _db = db;

    [HttpGet] public ActionResult<IEnumerable<Booking>> Get() => _db.Bookings;

    [HttpGet("{id:int}")]
    public ActionResult<Booking> GetById(int id)
        => _db.Bookings.FirstOrDefault(b => b.Id == id) is { } b ? Ok(b) : NotFound();

    [HttpPost]
    public ActionResult<Booking> Create([FromBody] Booking input)
    {
        if (!ModelState.IsValid) return ValidationProblem(ModelState);

        var room = _db.Rooms.FirstOrDefault(r => r.Id == input.RoomId && r.Active);
        if (room is null) return BadRequest(new { error = "RoomId invalid or inactive." });
        if (input.Players > room.Capacity)
            return BadRequest(new { error = "Players exceed room capacity." });

        bool overlaps = _db.Bookings.Any(b => b.RoomId == input.RoomId &&
            Math.Abs((b.StartUtc - input.StartUtc).TotalMinutes) < 90);
        if (overlaps) return Conflict(new { error = "Time slot overlaps with existing booking." });

        input.Id = _db.NewBookingId();
        _db.Bookings.Add(input);
        return CreatedAtAction(nameof(GetById), new { id = input.Id }, input);
    }

    [HttpPatch("{id:int}/approve")]
    public ActionResult<Booking> Approve(int id)
    {
        var idx = _db.Bookings.FindIndex(b => b.Id == id);
        if (idx < 0) return NotFound();
        var b = _db.Bookings[idx]; b.Approved = true; _db.Bookings[idx] = b;
        return Ok(b);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var b = _db.Bookings.FirstOrDefault(x => x.Id == id);
        if (b is null) return NotFound();
        _db.Sessions.RemoveAll(s => s.BookingId == id);
        _db.Bookings.Remove(b);
        return NoContent();
    }
}
