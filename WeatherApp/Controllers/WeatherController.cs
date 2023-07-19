using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WeatherApp.Business;

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
        private readonly Weather _weather;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="weatherRepository"></param>
        public WeatherController(ILogger<WeatherController> logger, Weather weather)
        {
            _logger = logger;
            _weather = weather;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("CanWeLunchOutside")]
        public async Task<ActionResult<string>> CanWeLunchOutsideAsync()
        {
            try
            {
                var result = _weather.CanWeLunchOutsideAsync();
                return Ok(result.Result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
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
                var result = _weather.GetWeather(dateTime);
                return Ok(JsonSerializer.Serialize(result.Result));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllWeatherData")]
        public ActionResult<string> GetAllWeather()
        {
            try
            {
                var result = _weather.GetAllWeatherData();
                return Ok(JsonSerializer.Serialize(result.Result));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
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
                var result =  _weather.SaveCurrentWeatherInTheDatabase();
                return Ok(JsonSerializer.Serialize(result.Result));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }
    }
}