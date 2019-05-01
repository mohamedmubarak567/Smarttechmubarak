using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mubaraktask.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
    }
}