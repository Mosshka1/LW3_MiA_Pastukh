using Models;

namespace Data;

public class InMemoryDb
{
    public List<Room> Rooms { get; } = new();
    public List<Scenario> Scenarios { get; } = new();
    public List<Booking> Bookings { get; } = new();
    public List<GameSession> Sessions { get; } = new();

    public int NextRoomId { get; private set; } = 0;
    public int NextScenarioId { get; private set; } = 0;
    public int NextBookingId { get; private set; } = 0;
    public int NextSessionId { get; private set; } = 0;

    public int NewRoomId() => ++NextRoomId;
    public int NewScenarioId() => ++NextScenarioId;
    public int NewBookingId() => ++NextBookingId;
    public int NewSessionId() => ++NextSessionId;
}
