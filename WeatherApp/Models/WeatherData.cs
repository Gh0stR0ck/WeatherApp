using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WeatherApp.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class WeatherData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public int Temperature { get; set; }
        public int WindSpeed { get; set; }
        public int WindDirection { get; set; }
        public int Humidity { get; set; }
        public int Cloud { get; set; }
        public DateTime DateTime { get; set; }
    }
}
