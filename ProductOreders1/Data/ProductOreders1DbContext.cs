using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOreders1.Data
{
    public class ProductOreders1DbContext:DbContext
    {
        public ProductOreders1DbContext()
        {

        }
        public ProductOreders1DbContext(DbContextOptions<ProductOreders1DbContext> options) : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
