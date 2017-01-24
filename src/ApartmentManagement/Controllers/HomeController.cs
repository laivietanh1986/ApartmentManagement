using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Information about your page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page. with google image ";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
