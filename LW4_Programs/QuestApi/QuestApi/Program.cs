var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

RoomEndpoints.MapRoomEndpoints(app);
UserEndpoints.MapUserEndpoints(app);
ReservationEndpoints.MapReservationEndpoints(app);
ReviewEndpoints.MapReviewEndpoints(app);


app.Run();
