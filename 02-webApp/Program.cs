var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
    Results.Content(@"
<html>
<body>
<h2>Login Page</h2>
<form method='post' action='/login'>
    <input name='email' placeholder='Email' />
    <br/><br/>
    <input name='password' type='password' placeholder='Password' />
    <br/><br/>
    <button type='submit'>Login</button>
</form>
</body>
</html>
", "text/html")
);

app.MapPost("/login",
    ([Microsoft.AspNetCore.Mvc.FromForm] string email,
     [Microsoft.AspNetCore.Mvc.FromForm] string password) =>
{
    if (email == "admin@test.com" && password == "1234")
        return Results.Content("Login Successful!", "text/plain");

    return Results.Content("Invalid Email or Password", "text/plain");
})
.DisableAntiforgery();  

app.Run();
