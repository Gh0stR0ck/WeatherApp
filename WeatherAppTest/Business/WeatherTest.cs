using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherApp.Business;
using WeatherApp.Data;
using WeatherApp.Data.DtoDb;
using WeatherApp.Data.Repositories;
using WeatherApp.Interfaces.Repositories;
using WeatherApp.Interfaces.Services;
using WeatherApp.Models;
using WeatherApp.Services;

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

            var weatherInfo = new WeatherInfo()
            {
                current_condition = new CurrentCondition[]
                {
                    new CurrentCondition
                    {
                        FeelsLikeC = "20",
                        windspeedKmph = "2000",
                        winddirDegree = "20",
                        humidity = "20",
                        cloudcover = "20",
                        localObsDateTime = "20"
                    }
                }
            };


            weatherInfoService.Setup(x => x.GetCurrentWeatherData()).ReturnsAsync(weatherInfo);

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

            var weatherInfo = new WeatherInfo()
            {
                current_condition = new CurrentCondition[]
                {
                    new CurrentCondition
                    {
                        FeelsLikeC = "8",
                        windspeedKmph = "2000",
                        winddirDegree = "20",
                        humidity = "20",
                        cloudcover = "20",
                        localObsDateTime = "20"
                    }
                }
            };


            weatherInfoService.Setup(x => x.GetCurrentWeatherData()).ReturnsAsync(weatherInfo);

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
