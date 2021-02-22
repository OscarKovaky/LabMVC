
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


using WebAppLab5.Models;

namespace WebAppLab5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHostingEnvironment _environment;
        public HomeController(ILogger<HomeController> logger, IHostingEnvironment env)
        {
            _logger = logger;
            _environment = env;
        }

        public IActionResult Index()
        {
            var Country = new List<Country>
            {
                new Country { ID = 101, Name = "Book", Continent= "Canada", Code= "Red" },
                new Country { ID = 102, Name = "Bike", Continent = "USA", Code = "Red" },
                new Country { ID = 103, Name = "Fireworks", Continent = "Mexico", Code = "Red" }
            };
            return View("Index", Country);

           
        }


        [HttpGet]
        public IActionResult UpdateNationalFlag(string code)
        {
            var country = DataSource.Countries
                .SingleOrDefault(c => c.Code.Equals(code, StringComparison.CurrentCultureIgnoreCase));
            return View(country);
        }

        [HttpPost]
        public IActionResult UpdateNationalFlag(string code, IFormFile nationalFlagFile)
        {
            if (nationalFlagFile == null || nationalFlagFile.Length == 0)
                return RedirectToAction(nameof(Index));
            var targetFileName = $"{code}{Path.GetExtension(nationalFlagFile.FileName)}";
            var relativeFilePath = Path.Combine("images", targetFileName);
            var absolutFilePath = Path.Combine(_environment.WebRootPath, relativeFilePath);
            var country = DataSource.Countries
                .SingleOrDefault(c => c.Code.Equals(code, StringComparison.CurrentCultureIgnoreCase));
            country.NationalFlagPath = relativeFilePath;
            using (var stream = new FileStream(absolutFilePath, FileMode.Create))
            {
                nationalFlagFile.CopyTo(stream);
            }

            return RedirectToAction(nameof(Index));
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
