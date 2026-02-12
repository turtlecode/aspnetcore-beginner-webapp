var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hello", (HttpContext context) =>
{
    var name = context.Request.Query["name"].ToString();

    if (string.IsNullOrEmpty(name))
        return "Please provide a name, e.g. /hello?name=Abruzzi";

    return $"Hello {name}! Welcome to ASP.NET.";
});

app.Run();
