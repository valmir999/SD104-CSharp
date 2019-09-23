﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMusicStore.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
            return "Welcome to my store.";
        }

        public IActionResult OpenStore()
        {
            return View();
        }
    }
}