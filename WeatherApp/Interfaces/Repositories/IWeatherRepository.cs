using WeatherApp.Models;

namespace WeatherApp.Interfaces.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWeatherRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<WeatherData>> GetAllWeatherData();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public Task<WeatherData> GetWeatherDataOnDateTime(DateTime datetime);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="weatherdata"></param>
        public Task AddWeatherData(WeatherData weatherdata);
    }
}
