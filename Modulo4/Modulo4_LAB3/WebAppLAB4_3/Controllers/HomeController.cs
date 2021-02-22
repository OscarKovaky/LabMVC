using Microsoft.AspNetCore.Mvc;


namespace WebAppLAB4_3.Controllers
{
    public class HomeController : Controller
    {
        


            public IActionResult Home() => View();
            public IActionResult Page1() => View();
            public IActionResult Page2() => View();
         
        

        

        
    }
}
