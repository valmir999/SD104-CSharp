﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMusicStore.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "New...the Matrix has you...";
        }
        public IActionResult HelloWorld()
        {
            return View();
        }
    }
}