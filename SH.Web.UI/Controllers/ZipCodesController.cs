﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;

namespace SH.Web.UI.Controllers
{
    public class ZipCodesController : Controller
    {
        // GET: ZipCodes
        public JsonResult Index()
        {
            return Json("true");
        }
    }
}