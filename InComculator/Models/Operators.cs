using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InComculator.Models
{
    public class Operators
    {
        [Key]
        public int pk_Id { get; set; }
        public string Name { get; set; }
    }
}