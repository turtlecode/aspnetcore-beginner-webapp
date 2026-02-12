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

app.Run();

