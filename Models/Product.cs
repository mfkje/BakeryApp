using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryApp.Models
{
    public class Product
    {
        public long ID { get; set; }

        [Required(ErrorMessage = "Product must have name")]
        [MinLength(3,ErrorMessage = "Minium Length of name is 3 characters")]
        [MaxLength(30, ErrorMessage = "Maximum Length of name is 30 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Product must have a description")]
        [MinLength(10, ErrorMessage = "Minium Length of description is 10 characters")]
        [MaxLength(250, ErrorMessage = "Maximum Length of description is 250 characters")]
        public string? Description { get; set; }


        //[Required(ErrorMessage ="Product must have a Category")]
        public long CategoryID { get; set; }
        public Category? Category { get; set; }

        public string? Image { get; set; }

        [Required(ErrorMessage ="Product must have a price")]
        [Column(TypeName ="decimal(7,2)")]
        [Range(0.50, 10000.00,ErrorMessage ="Price Range must be between $0.50 and $10'000.00")]
        public decimal Price { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }


    }
}
