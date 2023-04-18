namespace WeatherApp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CurrentCondition
    {
        public string? FeelsLikeC { get; set; }
        public string? windspeedKmph { get; set; }
        public string? winddirDegree { get; set; }
        public string? humidity { get; set; }
        public string? cloudcover { get; set; }
        public string? localObsDateTime { get; set; }
    }
}
