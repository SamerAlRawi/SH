using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using SH.Business;

namespace SH.Web.UI.Controllers
{
    public class ZipCodesController : Controller
    {
        private readonly IZipCodesService _zipCodesService;

        public ZipCodesController(IZipCodesService zipCodesService)
        {
            _zipCodesService = zipCodesService;
        }

        public JsonResult Index()
        {
            return Json(_zipCodesService.GetRandomZipCodes(10), JsonRequestBehavior.AllowGet);
        }
    }
}