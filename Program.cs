var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/",() =>
{
    return "API Farmacia funcionando";
});

app.MapGet("/api/farmacia",() =>
{
    return Results.Ok(new[]
    {
        new{
            id=1,
            codigo="P001",
            nombre="Amoxicilina",
        },
        new{
            id=2,
            codigo="P002",
            nombre="Partacetamol",
        }
    });
});


app.Run();