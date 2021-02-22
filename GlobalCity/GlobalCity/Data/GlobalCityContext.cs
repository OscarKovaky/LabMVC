using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using GlobalCity.Models;

namespace GlobalCity.Data
{
    public partial class GlobalCityContext : DbContext
    {

        

        public GlobalCityContext(DbContextOptions<GlobalCityContext> options)
            : base(options)
        {
        }


        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }



        

    }
}
