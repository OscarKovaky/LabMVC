using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationLAB4.Models;

namespace WebApplicationLAB4.Controllers
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

           
       
            var Products = new List<Product>();
            Products.Add(new Product { ID = 101, Name = "Book", Location = "Canada", Color="Red" });
            Products.Add(new Product { ID = 102, Name = "Bike", Location = "USA", Color = "Red" });
            Products.Add(new Product { ID = 103, Name = "Fireworks", Location = "Mexico", Color = "Red" });
            return View("Index", Products);
        
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
