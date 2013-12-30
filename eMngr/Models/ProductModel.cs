using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eMngr.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<ProductModel> Products { get; set; }
    }


    public class ProductModel  
    {
        public virtual int ID { get; set; }
        public virtual string sku { get; set; }
        public virtual string  Description{ get; set; }
    }
}