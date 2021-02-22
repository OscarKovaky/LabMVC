using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

#nullable disable

namespace GlobalCity.Models
{
    [Table("city")]
    [Index(nameof(CountryCode), Name = "CountryCode")]

    public partial class City
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "char(35)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "char(3)")]


     
        public string CountryCode { get; set; }
        [Required]
        [Column(TypeName = "char(20)")]
        public string District { get; set; }
        public int Population { get; set; }

        [ForeignKey(nameof(CountryCode))]
        [InverseProperty(nameof(Country.Cities))]
        public virtual Country CountryCodeNavigation { get; set; }
    }
}
