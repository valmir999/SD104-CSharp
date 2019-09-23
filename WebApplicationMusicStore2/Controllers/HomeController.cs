using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMusicStore2.Models;
using WebApplicationMusicStore2.Data;

namespace WebApplicationMusicStore2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            //            return View(_context.Song.Where(m => m.IsFeatured).ToList());
            return View(_context.Song.ToList());
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Albums()
        {
            return View(_context.Song.GroupBy(x => x.Album).Select(grp => grp.First()).ToList());
        }
        public IActionResult Songs()
        {
//            return View(_context.Song.Where(m => m.IsActive).ToList());
            return View(_context.Song.ToList());
        }
    }
}
