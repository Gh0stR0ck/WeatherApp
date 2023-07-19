using System.Text.Json;
using WeatherApp.Interfaces.Services;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class WeatherInfoService : IWeatherInfoService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<WeatherInfo> GetCurrentWeatherData()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://wttr.in/?format=j1");
            var wttrData = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<WeatherInfo>(wttrData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
