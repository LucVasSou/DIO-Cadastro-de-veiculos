using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using MinimalApi.Infraestrutura.Db;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContexto>(options =>
{
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySql"))
    );
});

var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (MinimalApi.Dtos.LoginDto loginDto) =>
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
