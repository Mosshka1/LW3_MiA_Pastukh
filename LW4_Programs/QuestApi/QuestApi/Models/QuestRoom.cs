using System.ComponentModel.DataAnnotations;

public class QuestRoom
{
    public int Id { get; set; }

    [Required, MinLength(3)]
    public string Title { get; set; } = "";

    [Required, MinLength(10)]
    public string Description { get; set; } = "";

    [Range(1, 20)]
    public int MaxPlayers { get; set; }

    [Range(0, double.MaxValue)]
    public decimal PricePerHour { get; set; }

    public List<string> Tags { get; set; } = new();
}
