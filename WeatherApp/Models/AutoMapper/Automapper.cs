using AutoMapper;
using WeatherApp.Models.Dto;

namespace WeatherApp.Models.AutoMapper
{
    public class AutomapperWeatherInfo : Profile
    {
        public AutomapperWeatherInfo()
        {
            //source mapping to destination
            CreateMap<CurrentCondition, WeatherData>()
                .ForMember(des => des.Temperature, opt => opt.MapFrom(src => int.Parse(src.FeelsLikeC)))
                .ForMember(des => des.WindSpeed, opt => opt.MapFrom(src => int.Parse(src.windspeedKmph)))
                .ForMember(des => des.WindDirection, opt => opt.MapFrom(src => int.Parse(src.winddirDegree)))
                .ForMember(des => des.Humidity, opt => opt.MapFrom(src => int.Parse(src.humidity)))
                .ForMember(des => des.Cloud, opt => opt.MapFrom(src => int.Parse(src.cloudcover)))
                .ForMember(des => des.DateTime, opt => opt.MapFrom(src => DateTime.Parse(src.localObsDateTime)))
                .ForMember(des => des.Id, act => act.Ignore());
        }
    }
}
