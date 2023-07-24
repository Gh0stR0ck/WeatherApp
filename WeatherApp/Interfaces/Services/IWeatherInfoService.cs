using WeatherApp.Models;

namespace WeatherApp.Interfaces.Services
{
    public interface IWeatherInfoService
    {
        public Task<WeatherData> GetCurrentWeatherData();
    }
}
