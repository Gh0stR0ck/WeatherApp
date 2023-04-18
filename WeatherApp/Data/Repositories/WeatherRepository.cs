using WeatherApp.Controllers;
using WeatherApp.Interfaces.DtoDb;
using WeatherApp.Interfaces.Repositories;

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
        public IEnumerable<WeatherData> GetAllWeatherData()
        {
            return _weatherContext.WeatherData.ToList();
        }

        /// <inheritdoc/>
        public WeatherData? GetWeatherDataOnDateTime(DateTime datetime)
        {
            return _weatherContext.WeatherData.First<WeatherData>(x => x.DateTime == datetime);
        }

        /// <inheritdoc/>
        public void AddWeatherData(WeatherData weatherdata)
        {
            _weatherContext.WeatherData.Add(weatherdata);
            Save();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Save()
        {
            _weatherContext.SaveChanges();
        }
    }
}
