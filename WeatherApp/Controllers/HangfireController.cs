using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherApp.Business;

namespace WeatherApp.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HangfireController : ControllerBase
    {
        private readonly ILogger<HangfireController> _logger;
        private readonly Weather _weather;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public HangfireController(ILogger<HangfireController> logger, Weather weather)
        {
            _logger = logger;
            _weather = weather;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("StartRecurringJob")]
        public ActionResult<string> StartRecurringJob()
        {
            try
            {
                RecurringJob.AddOrUpdate("SaveNewWeatherData", () => _weather.SaveCurrentWeatherInTheDatabase(), Cron.MinuteInterval(1));
                return Ok();
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
        [HttpGet("EndRecurringJob")]
        public ActionResult<string> EndRecurringJob()
        {
            try
            {
                RecurringJob.RemoveIfExists("myrecurringjob");
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }
    }
}
