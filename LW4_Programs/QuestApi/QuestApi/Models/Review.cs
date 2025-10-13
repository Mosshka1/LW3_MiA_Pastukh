using System.ComponentModel.DataAnnotations;

public class Review
{
    public int Id { get; set; }
    [Required] public int QuestRoomId { get; set; }
    [Required, MinLength(2)] public string AuthorName { get; set; } = "";
    [Range(1, 5)] public int Rating { get; set; }
    [MinLength(5)] public string? Comment { get; set; }
}
