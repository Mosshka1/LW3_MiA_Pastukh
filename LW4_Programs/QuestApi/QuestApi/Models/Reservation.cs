using System.ComponentModel.DataAnnotations;

public class Reservation
{
    public int Id { get; set; }

    [Required]
    public int QuestRoomId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public DateTime StartAt { get; set; }   

    [Range(1, 8)]
    public int Hours { get; set; } = 1;
}
