using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProductOreders1.Data.EnumFoods;

namespace ProductOreders1.Data
{
    
    public class Product
    {
        public  int Id { get; set; }
        public  string Name { get; set; }
        public  decimal Price { get; set; }
        public  string descrption { get; set; }
        public  Type Type { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
