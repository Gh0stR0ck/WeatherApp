using Moq;
using WeatherApp.Business;
using WeatherApp.Interfaces.Repositories;
using WeatherApp.Interfaces.Services;
using WeatherApp.Models;
using WeatherApp.Models.Dto;

namespace WeatherAppTest.Business
{
    public class WeatherTest
    {

        /// <summary>
        /// Usefull mock
        /// </summary>
        [Fact]
        public void CanWeLunchOutsideAsyncTest_Positive_True()
        {
            var weatherInfoService = new Mock<IWeatherInfoService>();
            var weather = new Weather(null,null, weatherInfoService.Object);

            var weatherData = new WeatherData()
            {
                Id = 1,
                Temperature = 20,
                WindSpeed = 1,
                WindDirection = 4,
                Humidity = 5,
                Cloud = 5,
                DateTime = DateTime.Now
            };


            weatherInfoService.Setup(x => x.GetCurrentWeatherData()).ReturnsAsync(weatherData);

            var result = weather.CanWeLunchOutsideAsync();

            Assert.True(result.Result);
        }

        /// <summary>
        /// Usefull mock
        /// </summary>
        [Fact]
        public void CanWeLunchOutsideAsyncTest_Positive_False()
        {
            var weatherInfoService = new Mock<IWeatherInfoService>();
            var weather = new Weather(null, null, weatherInfoService.Object);


            var weatherData = new WeatherData()
            {
                Id = 1,
                Temperature = 2,
                WindSpeed = 3000,
                WindDirection = 999,
                Humidity = 200,
                Cloud = 0,
                DateTime = DateTime.Now
            };


            weatherInfoService.Setup(x => x.GetCurrentWeatherData()).ReturnsAsync(weatherData);

            var result = weather.CanWeLunchOutsideAsync();

            Assert.False(result.Result);
        }

        /// <summary>
        /// Useless Mock
        /// </summary>
        [Fact]
        public void GetWeather_Positive_True()
        {
            var weatherRepository = new Mock<IWeatherRepository>();
            var weather = new Weather(null, weatherRepository.Object, null);

            var datetime = DateTime.Now;
            var weatherData = new WeatherData()
            {
                Id = 1231254125,
                Temperature = 20
            };

            weatherRepository.Setup(x => x.GetWeatherDataOnDateTime(datetime)).ReturnsAsync(weatherData);

            var result = weather.GetWeather(datetime);

            Assert.True(result.Result.Temperature == 20);
        }
    }
}
