var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<string> users = new();

string RenderPage()
{
    string html = @"
<html>
<body>
<h2>Add User</h2>

<form method='post'>
    <input name='name' placeholder='Enter name' />
    <button type='submit'>Add</button>
</form>

<hr/>

<h3>User List</h3>
<ul>";

    foreach (var user in users)
    {
        html += $"<li>{user}</li>";
    }

    html += "</ul></body></html>";

    return html;
}

app.MapGet("/", () =>
    Results.Content(RenderPage(), "text/html")
);

app.MapPost("/",
    ([Microsoft.AspNetCore.Mvc.FromForm] string name) =>
{
    if (!string.IsNullOrWhiteSpace(name))
    {
        users.Add(name);
    }

    return Results.Content(RenderPage(), "text/html");
})
.DisableAntiforgery();

app.Run();
