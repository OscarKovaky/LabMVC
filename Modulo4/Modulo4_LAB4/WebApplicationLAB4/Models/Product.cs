using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationLAB4.Models
{
    public class Product
    {


        public int ID { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }
        public string Color { get; set; }

        public IList<Product> Products { get; set; }

    }

 
  


}

