using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Addition
    {
        [Required]
        public string Name { get; set;}
        public string RestName { get; set; }
        public string? FavDish { get; set; } = "It's all tasty!";
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Invalid phone number input")]
        public string Phone { get; set; }
    }
}
