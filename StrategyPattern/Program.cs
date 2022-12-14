using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using StrategyPattern.Contracts.v1;
using StrategyPattern.Enum.v1;
using StrategyPattern.Models.v1;
using StrategyPattern.Services;
using StrategyPattern.Services.v1;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.RegisterAllTypes<IStrategy>(new[] { typeof(Program).Assembly });

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
