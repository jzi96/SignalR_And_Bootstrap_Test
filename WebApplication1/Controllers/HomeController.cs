﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        // GET: /Home/
        public ActionResult Demo()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
    }
}