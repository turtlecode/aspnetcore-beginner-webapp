var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
    Results.Content("<h1>Hello World from ASP.NET!</h1>", "text/html")
);

app.Run();
