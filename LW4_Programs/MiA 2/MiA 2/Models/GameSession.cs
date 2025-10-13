namespace Models;

public class GameSession
{
    public int Id { get; set; }
    public int BookingId { get; set; }
    public SessionStatus Status { get; set; } = SessionStatus.Scheduled;
    public string? Notes { get; set; }
}
