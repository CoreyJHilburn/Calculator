using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InComculator.Models
{
    public class CalculatorContext : DbContext
    {
        public CalculatorContext()
        {
            Database.SetInitializer<CalculatorContext>(null);
        }
        public DbSet<Operators> Operators { get; set; }
    }

}