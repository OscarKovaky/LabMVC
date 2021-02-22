using System;
using System.Linq;

using System.Collections.Generic;

namespace DemoModelos
{
    public class Repository
    {
       public List<Product> Products = new List<Product>
        {

            new Product
            {
            ProductID=1,
            ProductName="Azucar",
            UnitPrice=10,
            UnitsInStock=20
            },


            new Product
            {
            ProductID=2,
            ProductName="Frijoles",
            UnitPrice=10,
            UnitsInStock=20
            },

            new Product
            {
            ProductID=3,
            ProductName="Leche",
            UnitPrice=10,
            UnitsInStock=20
            },

            new Product
            {
            ProductID=4,
            ProductName="Arandanos",
            UnitPrice=10,
            UnitsInStock=20
            }

        };


        public Product GetProductID(int ID)
        {
            return Products.FirstOrDefault(p => p.ProductID == ID);
        }

       



    }
}
