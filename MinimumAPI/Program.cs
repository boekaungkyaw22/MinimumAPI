var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

// Routing
// "/shirts"

app.MapGet("/shirts", () =>
{
    return "Reading all the shirts";
});

app.MapGet("/shirts/{id}", (int id) =>
{
    return $"Reading the shift Id: {id}";
});

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
