using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using SH.Business;

namespace SH.Web.UI.Controllers
{
    public class ZipCodesController : Controller
    {
        private readonly IZipCodesService _zipCodesService;
        private readonly IWeatherService _weatherService;

        public ZipCodesController(IZipCodesService zipCodesService, IWeatherService weatherService)
        {
            _zipCodesService = zipCodesService;
            _weatherService = weatherService;
        }

        public JsonResult Index()
        {
            return Json(_zipCodesService.GetZipCodes(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetWeather(long id)
        {
            var weather = _weatherService.GetWeatherResult(id);
            return Json(weather, JsonRequestBehavior.AllowGet);

        }
    }

}