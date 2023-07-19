using Microsoft.EntityFrameworkCore;
using WeatherApp.Data.DtoDb;

namespace WeatherApp.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class WeatherContext : DbContext
    {
        public DbSet<WeatherData> WeatherData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new DataSeeder(modelBuilder).WeatherData();
        }
    }
}
