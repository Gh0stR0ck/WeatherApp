using Microsoft.EntityFrameworkCore;
using WeatherApp.Business;
using WeatherApp.Data;
using WeatherApp.Data.Repositories;
using WeatherApp.Interfaces.Repositories;
using WeatherApp.Interfaces.Services;
using WeatherApp.Services;
using Hangfire;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<WeatherContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IWeatherRepository, WeatherRepository>();
builder.Services.AddScoped<IWeatherInfoService, WeatherInfoService>();
builder.Services.AddScoped<Weather>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add hangfire
builder.Services.AddHangfire(configuration => configuration
            .UseSimpleAssemblyNameTypeSerializer()
            .UseRecommendedSerializerSettings()
            .UseSqlServerStorage(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddHangfireServer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHangfireDashboard();
    app.MapHangfireDashboard();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();