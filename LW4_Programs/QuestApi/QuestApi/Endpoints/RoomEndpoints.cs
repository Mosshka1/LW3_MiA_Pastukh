using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public static class RoomEndpoints
{
    public static void MapRoomEndpoints(this WebApplication app)
    {
        app.MapGet("/rooms", () => Results.Ok(QuestData.Rooms));

        app.MapGet("/rooms/{id:int}", (int id) =>
        {
            var r = QuestData.Rooms.FirstOrDefault(x => x.Id == id);
            return r is null ? Results.NotFound() : Results.Ok(r);
        });

        app.MapPost("/rooms", (QuestRoom model) =>
        {
            var errors = Validate(model);
            if (errors.Any()) return Results.BadRequest(errors);

            var rooms = QuestData.Rooms;
            model.Id = (rooms.Any() ? rooms.Max(r => r.Id) : 0) + 1;
            rooms.Add(model);
            return Results.Created($"/rooms/{model.Id}", model);
        });

        app.MapPut("/rooms/{id:int}", (int id, QuestRoom model) =>
        {
            var rooms = QuestData.Rooms;
            var existing = rooms.FirstOrDefault(r => r.Id == id);
            if (existing is null) return Results.NotFound();

            var errors = Validate(model);
            if (errors.Any()) return Results.BadRequest(errors);

            existing.Title = model.Title;
            existing.Description = model.Description;
            existing.MaxPlayers = model.MaxPlayers;
            existing.PricePerHour = model.PricePerHour;
            existing.Tags = model.Tags;

            return Results.Ok(existing);
        });

        app.MapDelete("/rooms/{id:int}", (int id) =>
        {
            var rooms = QuestData.Rooms;
            var existing = rooms.FirstOrDefault(r => r.Id == id);
            if (existing is null) return Results.NotFound();
            rooms.Remove(existing);
            return Results.NoContent();
        });

        static List<string> Validate(QuestRoom m)
        {
            var ctx = new ValidationContext(m);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(m, ctx, results, true))
                return results.Select(r => r.ErrorMessage ?? "Validation error").ToList();
            return new();
        }
    }
}
