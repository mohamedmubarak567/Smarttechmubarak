using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mubaraktask.Models
{
    public class ProductCatalogEntities : DbContext
    {
        public ProductCatalogEntities(): base("DefaultConnection")
        {
 
        }
        public DbSet<Products> Products { get; set; }
    }

}