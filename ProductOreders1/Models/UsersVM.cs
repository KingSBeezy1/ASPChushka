using Microsoft.AspNetCore.Mvc.Rendering;
using ProductOreders1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static ProductOreders1.Data.EnumRoles;

namespace ProductOreders1.Models
{
    public class UsersVM
    {
       [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength = 3, ErrorMessage = "You need atleast 3 letters")]
        public string Username { get; set; }
        [Required]
        [StringLength(18, MinimumLength = 6, ErrorMessage = "You need atleast 6 letters")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public string FullNmae { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public string Email { get; set; }
        [Required]
        [EnumDataType(typeof(TypeRoles))]
        public TypeRoles Role { get; set; }
        [NotMapped]
         public List<SelectListItem> Orders { get; set; }
    }
}
