var builder = WebApplication.CreateBuilder(args);

// Add services to the container

// tells ASP.NET Core to look at your minimal API endpoints
// "hey ASP.NET, scan my API so others (and tools) can understand it” 
builder.Services.AddEndpointsApiExplorer();
// generates the Swagger/OpenAPI specification and the Swagger UI
// “take all the endpoint info and make a visual playground + machine-readable file”
builder.Services.AddSwaggerGen();

// optional: keep OpenAPI if you want
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure Swagger / OpenAPI
if (app.Environment.IsDevelopment()) // checks if your app is running in development mode
{
    app.UseSwagger(); // exposes the OpenAPI spec as a JSON file
    app.UseSwaggerUI(); // provides the interactive Swagger web page
    app.MapOpenApi();  // optional : maps the OpenAPI endpoint in minimal API style
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
