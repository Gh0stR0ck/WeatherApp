using Microsoft.EntityFrameworkCore;
using WeatherApp.Controllers;
using WeatherApp.Interfaces.Repositories;
using WeatherApp.Models;

namespace WeatherApp.Data.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class WeatherRepository : IWeatherRepository
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly WeatherContext _weatherContext;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="weatherContext"></param>
        public WeatherRepository(ILogger<WeatherController> logger, WeatherContext weatherContext)
        {
            _logger = logger;
            _weatherContext = weatherContext;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<WeatherData>> GetAllWeatherData()
        {
            return await _weatherContext.WeatherData.ToListAsync();
        }

        /// <inheritdoc/>
        public async Task<WeatherData?> GetWeatherDataOnDateTime(DateTime datetime)
        {
            return await _weatherContext.WeatherData.FirstOrDefaultAsync<WeatherData>(x => x.DateTime == datetime);
        }

        /// <inheritdoc/>
        public async Task AddWeatherData(WeatherData weatherdata)
        {
            await _weatherContext.WeatherData.AddAsync(weatherdata);
            await _weatherContext.SaveChangesAsync();
        }
    }
}
