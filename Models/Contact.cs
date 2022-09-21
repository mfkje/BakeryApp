using System.ComponentModel.DataAnnotations;

namespace BakeryApp.Models
{
    public class Contact
    {

        public long ID { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [MinLength(3, ErrorMessage = "Minium Length of name is 3 characters")]
        [MaxLength(30, ErrorMessage = "Maximum Length of name is 30 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a valid email address")]
        [MinLength(3, ErrorMessage = "Minium Length of name is 5 characters")]
        [MaxLength(30, ErrorMessage = "Maximum Length of name is 50 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Form must have an email")]
        [MinLength(10, ErrorMessage = "Minium Length of description is 10 characters")]
        [MaxLength(250, ErrorMessage = "Maximum Length of description is 250 characters")]
        public string Message { get; set; }
    }
}

