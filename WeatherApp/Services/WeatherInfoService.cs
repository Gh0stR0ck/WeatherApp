using AutoMapper;
using System.Text.Json;
using WeatherApp.Business;
using WeatherApp.Interfaces.Services;
using WeatherApp.Models;
using WeatherApp.Models.Dto;

namespace WeatherApp.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class WeatherInfoService : IWeatherInfoService
    {
        private readonly ILogger<Weather> _logger;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="weatherRepository"></param>
        public WeatherInfoService(ILogger<Weather> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<WeatherData> GetCurrentWeatherData()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://wttr.in/?format=j1");
            var wttrData = await response.Content.ReadAsStreamAsync();
            var currentWeatherData = await JsonSerializer.DeserializeAsync<WeatherInfo>(wttrData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var result = _mapper.Map<WeatherData>(currentWeatherData.current_condition[0]);
            return result;
        }
    }
}
