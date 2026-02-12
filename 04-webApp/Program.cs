var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/user/{name}", (string name) =>
    $"Welcome, {name}!"
);

app.Run();