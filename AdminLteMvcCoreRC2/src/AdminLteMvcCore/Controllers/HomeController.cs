using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminLteMvcCore.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
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

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult chartjs()
        {
            return View();
        }
        public IActionResult advance() {
            return View();
        }
        public IActionResult calendar()
        {
            return View();
        }
        public IActionResult data()
        {
            return View();
        }
        public IActionResult editors()
        {
            return View();
        }
        public IActionResult flot()
        {
            return View();
        }
        public IActionResult general()
        {
            return View();
        }
        public IActionResult inline()
        {
            return View();
        }
        public IActionResult morris()
        {
            return View();
        }
        public IActionResult simple()
        {
            return View();
        }

        public IActionResult widgets()
        {
            return View();
        }
        public IActionResult buttons()
        {
            return View();
        }
        public IActionResult modals()
        {
            return View();
        }
        public IActionResult sliders()
        {
            return View();
        }
        public IActionResult ulgeneral()
        {
            return View();
        }
        public IActionResult timeline()
        {
            return View();
        }
        public IActionResult icons()
        {
            return View();

        }
    }
}
