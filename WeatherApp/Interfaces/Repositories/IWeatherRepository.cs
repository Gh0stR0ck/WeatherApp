using WeatherApp.Interfaces.DtoDb;

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
        public IEnumerable<WeatherData> GetAllWeatherData();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public WeatherData GetWeatherDataOnDateTime(DateTime datetime);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="weatherdata"></param>
        public void AddWeatherData(WeatherData weatherdata);
    }
}
