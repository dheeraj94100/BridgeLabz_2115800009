using BusinessLayer.Service;
using RepositoryLayer.Service;
using RepositoryLayer.Interface;
using BusinessLayer.Interface;
using RepositoryLayer.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<HelloAppContext>(options => options.UseSqlServer(connectionString));


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IRegisterHelloRL, RegisterHelloRL>();
builder.Services.AddScoped<IRegisterHelloBL, RegisterHelloBL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//app.UseSwagger();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// saare middlewares app.run() se pehle likhne hote hain

app.Run();
