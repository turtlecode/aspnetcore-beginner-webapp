var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/users", () =>
{
    string[] users = { "Scofield", "Abruzzi", "Sara", "Micheal" };

    string html = "<h2>User List</h2><ul>";

    foreach (var user in users)
        html += $"<li>{user}</li>";

    html += "</ul>";

    return Results.Content(html, "text/html");
});

app.Run();