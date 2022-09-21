using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryApp.Models
{
    public class Category
    {
        public long ID { get; set; }

        [Required(ErrorMessage ="Category must have a name")]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }
        
        public ICollection<Product> Products { get; set; }
    }
}
