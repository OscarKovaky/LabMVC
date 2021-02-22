using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebAppLAB4_2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAppLAB4_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["columnNames"] = new string[] { "ID", "Name", "Price" };
            ViewData["content"] = new string[,]{
        {"101", "Apple", "1.01"},
        {"202", "Back", "2.02"},
        {"303", "Cup", "3.03"},
        {"404", "Donut", "3.03"}
    };
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
    }
}
