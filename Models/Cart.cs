using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryApp.Models
{
    public class Cart
    {
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set;}

        public long ProductID { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }

    }
}
