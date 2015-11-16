﻿using AlisonVogel.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlisonVogel.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [TestException]
        public string Test()
        {
            throw new ArgumentOutOfRangeException();
        }


    }
}