using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this WebApplication app)
    {
        app.MapGet("/users", () => Results.Ok(QuestData.Users));

        app.MapGet("/users/{id:int}", (int id) =>
        {
            var u = QuestData.Users.FirstOrDefault(x => x.Id == id);
            return u is null ? Results.NotFound() : Results.Ok(u);
        });

        app.MapPost("/users", (User model) =>
        {
            var errors = Validate(model);
            if (errors.Any()) return Results.BadRequest(errors);

            var users = QuestData.Users;
            model.Id = (users.Any() ? users.Max(r => r.Id) : 0) + 1;
            users.Add(model);
            return Results.Created($"/users/{model.Id}", model);
        });

        app.MapPut("/users/{id:int}", (int id, User model) =>
        {
            var users = QuestData.Users;
            var existing = users.FirstOrDefault(r => r.Id == id);
            if (existing is null) return Results.NotFound();

            var errors = Validate(model);
            if (errors.Any()) return Results.BadRequest(errors);

            existing.FullName = model.FullName;
            existing.Email = model.Email;

            return Results.Ok(existing);
        });

        app.MapDelete("/users/{id:int}", (int id) =>
        {
            var users = QuestData.Users;
            var existing = users.FirstOrDefault(r => r.Id == id);
            if (existing is null) return Results.NotFound();
            users.Remove(existing);
            return Results.NoContent();
        });

        static List<string> Validate(User m)
        {
            var ctx = new ValidationContext(m);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(m, ctx, results, true))
                return results.Select(r => r.ErrorMessage ?? "Validation error").ToList();
            return new();
        }
    }
}
