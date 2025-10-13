using System.ComponentModel.DataAnnotations;

namespace Models;

public class Scenario
{
    public int Id { get; set; }

    [Required, MinLength(3)]
    public string Title { get; set; } = "";

    [Range(1, 240)]
    public int DurationMinutes { get; set; } = 60;

    [Required]
    public Difficulty Difficulty { get; set; }

    [Required]
    public int RoomId { get; set; }
}
