using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Data;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var cs = "Server = localhost; Port = 3306; Database = pokemon; Uid = pokemon; Pwd = pokemon";
builder.Services.AddDbContextPool<AppDbContext>(optionsAction: options => options.UseMySql(cs, ServerVersion.AutoDetect(cs)));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
