using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos.Models
{
    public class ProductController : Controller
    {
        public IActionResult Details(int id)


        {
            ActionResult Result = null;

            var Repository = new DemoModelos.Repository();

            var Model = Repository.GetProductID(id);

            if (Model != null) 
            {

                Result = View("Details2",Model);
            
            }
            else
            {

                Result = Content("Producto no encontrado");
            }



            return Result;
        }
    }
}
