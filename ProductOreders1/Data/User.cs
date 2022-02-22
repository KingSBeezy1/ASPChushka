using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOreders1.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullNmae { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }
         public virtual ICollection<Order> Orders { get; set; }
    }
}
