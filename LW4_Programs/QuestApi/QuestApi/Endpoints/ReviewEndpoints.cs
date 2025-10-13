using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public static class ReviewEndpoints
{
    public static void MapReviewEndpoints(this WebApplication app)
    {
        app.MapGet("/reviews", () => Results.Ok(QuestData.Reviews));

        app.MapGet("/reviews/{id:int}", (int id) =>
        {
            var r = QuestData.Reviews.FirstOrDefault(x => x.Id == id);
            return r is null ? Results.NotFound() : Results.Ok(r);
        });

        app.MapGet("/rooms/{roomId:int}/reviews", (int roomId) =>
        {
            if (!QuestData.Rooms.Any(r => r.Id == roomId))
                return Results.NotFound($"Room {roomId} not found");
            var list = QuestData.Reviews.Where(x => x.QuestRoomId == roomId).ToList();
            return Results.Ok(list);
        });
        app.MapPost("/reviews", (Review model) =>
        {
            var errors = Validate(model);
            if (!QuestData.Rooms.Any(r => r.Id == model.QuestRoomId))
                errors.Add("QuestRoomId not found.");
            if (errors.Any()) return Results.BadRequest(errors);

            model.Id = (QuestData.Reviews.Any() ? QuestData.Reviews.Max(r => r.Id) : 0) + 1;
            QuestData.Reviews.Add(model);
            return Results.Created($"/reviews/{model.Id}", model);
        });

        app.MapPut("/reviews/{id:int}", (int id, Review model) =>
        {
            var existing = QuestData.Reviews.FirstOrDefault(r => r.Id == id);
            if (existing is null) return Results.NotFound();

            var errors = Validate(model);
            if (!QuestData.Rooms.Any(r => r.Id == model.QuestRoomId))
                errors.Add("QuestRoomId not found.");
            if (errors.Any()) return Results.BadRequest(errors);

            existing.QuestRoomId = model.QuestRoomId;
            existing.AuthorName = model.AuthorName;
            existing.Rating = model.Rating;
            existing.Comment = model.Comment;

            return Results.Ok(existing);
        });

        app.MapDelete("/reviews/{id:int}", (int id) =>
        {
            var existing = QuestData.Reviews.FirstOrDefault(r => r.Id == id);
            if (existing is null) return Results.NotFound();
            QuestData.Reviews.Remove(existing);
            return Results.NoContent();
        });

        static List<string> Validate(Review m)
        {
            var ctx = new ValidationContext(m);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(m, ctx, results, true))
                return results.Select(r => r.ErrorMessage ?? "Validation error").ToList();
            return new();
        }
    }
}
