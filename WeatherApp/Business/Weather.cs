using Microsoft.AspNetCore.Mvc;
using WeatherApp.Data.DtoDb;
using WeatherApp.Interfaces.Repositories;
using WeatherApp.Interfaces.Services;
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
        public async Task<bool> CanWeLunchOutsideAsync()
        {
            var currentWeatherData = await _weatherInfoService.GetCurrentWeatherData();

            if (int.Parse(currentWeatherData?.current_condition[0]?.FeelsLikeC) > 18) return true;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public async Task<WeatherData> GetWeather(DateTime dateTime)
        {
            var result = await _weatherRepository.GetWeatherDataOnDateTime(dateTime);
            return result;
        }

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
        public async Task<string> SaveCurrentWeatherInTheDatabase()
        {
            try
            {
                WeatherInfoService weatherDataService = new WeatherInfoService();
                var currentWeatherData = await weatherDataService.GetCurrentWeatherData();

                var weatherData = new WeatherData
                {
                    Temperature = int.Parse(currentWeatherData?.current_condition[0]?.FeelsLikeC),
                    WindSpeed = int.Parse(currentWeatherData?.current_condition[0]?.windspeedKmph),
                    WindDirection = int.Parse(currentWeatherData?.current_condition[0]?.winddirDegree),
                    Humidity = int.Parse(currentWeatherData?.current_condition[0]?.humidity),
                    Cloud = int.Parse(currentWeatherData?.current_condition[0]?.cloudcover),
                    DateTime = DateTime.Parse(currentWeatherData?.current_condition[0]?.localObsDateTime),
                };

                _weatherRepository.AddWeatherData(weatherData);

                return "Saved succesfully";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Something went wrong.";
            }
        }
    }
}
