using MinimumAPI.Models.Validation;
using System.ComponentModel.DataAnnotations;

namespace MinimumAPI.Models
{
    public class Shirts
    {
        public int ShirtId { get; set; }

        [Required] 
        public string? Brand { get; set; }
        [Required]
        public string? Color { get; set; }

        [Shirt_Size_Validation]
        public int? Size { get; set; }
        [Required]
        public string? Gender { get; set; }
        public double? Price { get; set; }
    }
}
