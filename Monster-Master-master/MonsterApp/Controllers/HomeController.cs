using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonsterApp.Context;
using MonsterApp.Models;

namespace MonsterApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MonsterDBContext _context;

        public HomeController(MonsterDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "ASP.NET Monster Master Application";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your Monster Master";

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

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User objUser)
        {
            ModelState.Remove("FirstName");
            ModelState.Remove("LastName");
            if (ModelState.IsValid)
            {
                
                    var obj = _context.Users.Include(u=>u.UserType).Where(a => a.EmailAddress.Equals(objUser.EmailAddress) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        HttpContext.Session.SetString("UserType", obj.UserType.TypeName);
                        HttpContext.Session.SetString("UserID", obj.UserId.ToString());
                        HttpContext.Session.SetString("FullName", string.Format("{0} {1}", obj.FirstName, obj.LastName));
                        return RedirectToAction("Index");
                    }
                    else
                    {
                         return View();
                    }
                
            }
            return View(objUser);
        }
    }
}
