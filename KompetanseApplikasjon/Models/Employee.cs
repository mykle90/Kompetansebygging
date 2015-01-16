using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using KompetanseApplikasjon.Validators;

namespace KompetanseApplikasjon.Models
{
    public class Employee : IEmployee
    {
        
        public int EmployeeId { get; set; }
        //[StringLength(30, MinimumLength = 4, ErrorMessage = "Navnet er for kort")]
        [NameValidator(4,10, Test = "Heiiiiiiii")]
        public string Name { get; set; }
        [Range(0, 125, ErrorMessage = "Alder må være mellom 0 og 125")]
        public int Age { get; set; }
    }

    public class EmpolyeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

    }

}