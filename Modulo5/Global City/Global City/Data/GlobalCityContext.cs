using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Global_City.Models;


namespace Global_City.Data
{
    public class GlobalCityContext : DbContext
    {

        public GlobalCityContext(DbContextOptions<GlobalCityContext> options)
            : base(options)
        {
        }

        public DbSet<City> Citys { get; set; }

        public DbSet<Country> Countrys { get; set; }


    }
}

