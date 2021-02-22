using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalCity.Models
{
    [Table("country")]

    public partial class Country
    {


        public Country()
        {
            Cities = new HashSet<City>();
        }

        [Key]
        [Column(TypeName = "char(3)")]
        public string Code { get; set; }
        [Required]
        [Column(TypeName = "char(52)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "char(26)")]
        public string Region { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string NationalFlag { get; set; }

        [InverseProperty(nameof(City.CountryCodeNavigation))]
        public virtual ICollection<City> Cities { get; set; }

    }
}
