using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WeatherApp.Interfaces.DtoDb;
using WeatherApp.Interfaces.Repositories;
using WeatherApp.Services;

namespace WeatherApp.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly IWeatherRepository _weatherRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="weatherRepository"></param>
        public WeatherController(ILogger<WeatherController> logger, IWeatherRepository weatherRepository)
        {
            _logger = logger;
            _weatherRepository = weatherRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("CanWeLunchOutside")]
        public async Task<ActionResult<string>> LunchWeatherAsync()
        {
            WeatherInfoService weatherDataService = new WeatherInfoService();
            var currentWeatherData = await weatherDataService.GetCurrentWeatherData();

            if (int.Parse(currentWeatherData?.current_condition[0]?.FeelsLikeC) > 18) return "It's beautifull outside.";

            return "Better lunch behind the computer.";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        [HttpGet("GetWeatherDataOnDateTime")]
        public ActionResult<string> GetWeather(DateTime dateTime)
        {
            try
            {
                return JsonSerializer.Serialize(_weatherRepository.GetWeatherDataOnDateTime(dateTime));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Something went wrong.";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllWeatherData")]
        public ActionResult<string> GetAllWeather()
        {
            return JsonSerializer.Serialize(_weatherRepository.GetAllWeatherData());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("SaveCurrentWeatherInTheDatabase")]
        public async Task<ActionResult<string>> SaveCurrentWeatherInTheDatabase()
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