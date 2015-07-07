using System.Net;
using Newtonsoft.Json;
using SH.Business.Models;

namespace SH.Business
{
    public class WeatherService : IWeatherService
    {
        
        public WeatherResult GetWeatherResult(long zipCode)
        {
            var address = "http://api.openweathermap.org/data/2.5/weather?zip=" + zipCode;
            var client = new WebClient();

            string downloadString = client.DownloadString(address);
            return JsonConvert.DeserializeObject<WeatherResult>(downloadString);
        }
    }
}