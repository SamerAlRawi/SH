using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SH.Business.Models;

namespace SH.Business
{
    public interface IWeatherService
    {
        WeatherResult GetWeatherResult(long zipCode);
    }
}
