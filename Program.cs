
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.MapGet("/", () =>
{
    return "API Farmacia funcionando";
});

app.MapGet("/api/farmacia", () =>
{
    return Results.Ok(new[]
    {
        new
        {
            id = 1,
            codigo = "P001",
            nombre = "Amoxicilina"
        },
        new
        {
            id = 2,
            codigo = "P002",
            nombre = "Paracetamol"
        }
        new
        {
            id = 3,
            codigo = "P003",
            nombre = "Alprazolam",
        }
    });
});

var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";

app.Run($"http://0.0.0.0:{port}");

