using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDto loginDto) =>
{
    if (loginDto.Email == Environment.GetEnvironmentVariable("ADMIN_EMAIL") && loginDto.Senha == Environment.GetEnvironmentVariable("ADMIN_PASSWORD"))
    {
        return Results.Ok("Logado com sucesso!");
    }
    else
    {
        return Results.Unauthorized();
    }
});

app.Run();

public class LoginDto
{
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
}
