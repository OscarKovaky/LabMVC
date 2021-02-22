using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLab5.Models
{
    public class Country
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public string Continent { get; set; }
        public string Code { get; set; }

        public IList<Country> Countrys { get; set; }



    }
}
