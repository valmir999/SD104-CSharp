using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMusicStore.Controllers
{
    public class WhiteRabbitController : Controller
    {

        public string Index()
        {
            return "Welcome to White Rabbit.";
        }

        public IActionResult WhiteRabbit()
        {
            return View();
        }
    }
}