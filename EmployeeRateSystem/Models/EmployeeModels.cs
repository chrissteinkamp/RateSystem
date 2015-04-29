using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace EmployeeRateSystem.Models
{
    public class EmployeeModel
    {
        public string id { get; set; }

        [Display(Name = "First Name")]
        [StringLength(60, MinimumLength = 1)]
        public string FIRSTNAME { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(60, MinimumLength = 1)]
        public string LASTNAME { get; set; }

        [Display(Name = "Username")]
        [StringLength(60, MinimumLength = 1)]
        public string USERNAME { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime STARTDATE { get; set; }

        [Display(Name = "Department")]
        public string DEPARTMENT { get; set; }
    }
    public class EmployeeDBContext : DbContext
    {
        public DbSet<EmployeeModel> Employee { get; set; }
    }
}