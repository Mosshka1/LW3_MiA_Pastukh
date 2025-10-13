public static class QuestData
{
    public static List<QuestRoom> Rooms { get; } = new()
    {
        new QuestRoom { Id = 1, Title = "Lost Temple", Description = "A mysterious temple full of puzzles.", MaxPlayers = 6, PricePerHour = 25 },
        new QuestRoom { Id = 2, Title = "Space Station", Description = "Save the station before it's too late.", MaxPlayers = 5, PricePerHour = 30 }
    };

    public static List<User> Users { get; } = new()
    {
        new User { Id = 1, FullName = "Ivan Petrov", Email = "ivan@example.com" }
    };

    public static List<Reservation> Reservations { get; } = new();

    public static List<Review> Reviews { get; } = new();
}
