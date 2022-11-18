using StrategyPattern.Contracts.v1;
using StrategyPattern.Enum.v1;
using StrategyPattern.Models.v1;
using StrategyPattern.Services.v1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IStrategy, PixService>();
builder.Services.AddScoped<IStrategy, DebitCardService>();
builder.Services.AddScoped<IStrategy, WithdrawService>();
builder.Services.AddScoped<IStrategy, CreditCardService>();

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
