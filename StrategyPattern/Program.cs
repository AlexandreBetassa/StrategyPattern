using StrategyPattern.Contracts.v1;
using StrategyPattern.Models.v1;
using StrategyPattern.Services.v1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<PixService>();
builder.Services.AddTransient<IStrategy<Pix>, PixService>();
builder.Services.AddTransient<IStrategy<DebitCard>, DebitCardService>();
builder.Services.AddTransient<IStrategy<Withdraw>, WithdrawService>();
builder.Services.AddTransient<IStrategy<CreditCard>, CreditCardService>();

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
