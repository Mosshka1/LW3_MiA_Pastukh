namespace Models;

public class Booking
{
    public int Id { get; set; }
    public int RoomId { get; set; }
    public DateTime StartUtc { get; set; }
    public int Players { get; set; }
    public string CustomerName { get; set; } = "";
    public string CustomerPhone { get; set; } = ""; 
    public bool Approved { get; set; } = false;
}
