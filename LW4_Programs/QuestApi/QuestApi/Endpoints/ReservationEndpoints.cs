using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public static class ReservationEndpoints
{
    public static void MapReservationEndpoints(this WebApplication app)
    {
        app.MapGet("/reservations", () => Results.Ok(QuestData.Reservations));

        app.MapGet("/reservations/{id:int}", (int id) =>
        {
            var r = QuestData.Reservations.FirstOrDefault(x => x.Id == id);
            return r is null ? Results.NotFound() : Results.Ok(r);
        });

        app.MapPost("/reservations", (Reservation model) =>
        {
            var errors = Validate(model);

            if (!QuestData.Rooms.Any(r => r.Id == model.QuestRoomId))
                errors.Add("QuestRoomId not found.");
            if (!QuestData.Users.Any(u => u.Id == model.UserId))
                errors.Add("UserId not found.");

            var startUtc = model.StartAt.Kind == DateTimeKind.Unspecified
                ? DateTime.SpecifyKind(model.StartAt, DateTimeKind.Utc)
                : model.StartAt.ToUniversalTime();

            if (startUtc < DateTime.UtcNow)
                errors.Add("StartAt must be in the future.");
            var newEnd = startUtc.AddHours(model.Hours);
            bool overlaps = QuestData.Reservations.Any(r =>
                r.QuestRoomId == model.QuestRoomId &&
                ToUtc(r.StartAt) < newEnd &&
                startUtc < ToUtc(r.StartAt).AddHours(r.Hours));

            if (overlaps) errors.Add("Time slot overlaps with an existing reservation for this room.");

            if (errors.Any()) return Results.BadRequest(errors);

            model.StartAt = startUtc; 
            model.Id = (QuestData.Reservations.Any() ? QuestData.Reservations.Max(r => r.Id) : 0) + 1;
            QuestData.Reservations.Add(model);
            return Results.Created($"/reservations/{model.Id}", model);
        });

        app.MapDelete("/reservations/{id:int}", (int id) =>
        {
            var existing = QuestData.Reservations.FirstOrDefault(r => r.Id == id);
            if (existing is null) return Results.NotFound();
            QuestData.Reservations.Remove(existing);
            return Results.NoContent();
        });

        static DateTime ToUtc(DateTime dt) =>
            dt.Kind == DateTimeKind.Unspecified ? DateTime.SpecifyKind(dt, DateTimeKind.Utc) : dt.ToUniversalTime();

        static List<string> Validate(Reservation m)
        {
            var ctx = new ValidationContext(m);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(m, ctx, results, true))
                return results.Select(r => r.ErrorMessage ?? "Validation error").ToList();
            return new();
        }
    }
}
