using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Modulo4_LAB1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo4_LAB1.Controllers
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
            var vm = new ProductListVM();
            vm.Discount = new Discount { Start = DateTime.Today, End = DateTime.Today.AddDays(30), Rate = 0.75 };
            vm.Products = new List<Product>();
            vm.Products.Add(new Product { ID = 101, Name = "Book", Price = 20 });
            vm.Products.Add(new Product { ID = 102, Name = "Bike", Price = 30 });
            vm.Products.Add(new Product { ID = 103, Name = "Fireworks", Price = 40 });
            return View("Index", vm);


            
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
