using System.Net;
using Newtonsoft.Json;
using SH.Business.Models;

namespace SH.Business
{
    public class WeatherService : IWeatherService
    {
        
        public WeatherResult GetWeatherResult(long zipCode)
        {
            var address = "http://api.openweathermap.org/data/2.5/weather?APPID=ae3da21b2d77ae17b4559b11146e3c34&zip=" + zipCode;
            var client = new WebClient();

            string downloadString = client.DownloadString(address);
            return JsonConvert.DeserializeObject<WeatherResult>(downloadString);
        }
    }
}