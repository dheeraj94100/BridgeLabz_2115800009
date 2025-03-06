
using BusinessLayer.Interface;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLog;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using StackExchange.Redis;



var logger = LogManager.Setup().LoadConfigurationFromFile("nlog.config").GetCurrentClassLogger();
try
{
    logger.Info("Application Starting...");

    var builder = WebApplication.CreateBuilder(args);

    // Configure Redis connection
    var redisConfig = builder.Configuration.GetSection("Redis:ConnectionString").Value;
    builder.Services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect(redisConfig));

    // NLog ko use karne ke liye configure 

    builder.Logging.ClearProviders();
    builder.Logging.AddConsole(); //  console logging is enabled

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddScoped<IGreetingBL, GreetingBL>();
    builder.Services.AddScoped<IGreetingRL, GreetingRL>();

    var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
    builder.Services.AddDbContext<HelloGreetingContext>(options => options.UseSqlServer(connectionString));

    var app = builder.Build();

    // Swagger Enable

    app.UseSwagger();
    app.UseSwaggerUI();


    app.UseAuthorization();
    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "Application failed to start!");
    throw;
}
finally
{
    LogManager.Shutdown();
}