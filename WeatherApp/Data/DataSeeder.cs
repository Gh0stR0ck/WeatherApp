using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using WeatherApp.Models;

namespace WeatherApp.Data
{
    public class DataSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public DataSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void WeatherData()
        {
            for (int index = 1; index < 100; index++)
            {
                modelBuilder.Entity<WeatherData>().HasData(
                   new WeatherData() {
                       Id = index,
                       Temperature = RandomNumberGenerator.GetInt32(40),
                       WindSpeed = RandomNumberGenerator.GetInt32(500),
                       WindDirection = RandomNumberGenerator.GetInt32(360),
                       Humidity = RandomNumberGenerator.GetInt32(100),
                       Cloud = RandomNumberGenerator.GetInt32(100),
                       DateTime = DateTime.Now,
                   }
                );
            }
        }
    }
}
