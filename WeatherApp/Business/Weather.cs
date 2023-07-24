using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Interfaces.Repositories;
using WeatherApp.Interfaces.Services;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.Business
{
    public class Weather
    {
        private readonly ILogger<Weather> _logger;
        private readonly IWeatherRepository _weatherRepository;
        private readonly IWeatherInfoService _weatherInfoService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="weatherRepository"></param>
        public Weather(ILogger<Weather> logger, IWeatherRepository weatherRepository, IWeatherInfoService weatherInfoService)
        {
            _logger = logger;
            _weatherRepository = weatherRepository;
            _weatherInfoService = weatherInfoService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> CanWeLunchOutsideAsync() => CheckNiceWeatherConditions(await _weatherInfoService.GetCurrentWeatherData());

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public async Task<WeatherData> GetWeather(DateTime dateTime) => await _weatherRepository.GetWeatherDataOnDateTime(dateTime);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllWeatherData")]
        public async Task<IEnumerable<WeatherData>> GetAllWeatherData() => await _weatherRepository.GetAllWeatherData();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("SaveCurrentWeatherInTheDatabase")]
        public async Task SaveCurrentWeatherInTheDatabase()
        {
            var weatherData = await _weatherInfoService.GetCurrentWeatherData();
            await _weatherRepository.AddWeatherData(weatherData);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="weatherData"></param>
        /// <returns></returns>
        private bool CheckNiceWeatherConditions(WeatherData weatherData)
        {
            return (weatherData.Temperature > 18) ? true : false;
        }
    }
}
