using System.Diagnostics.Metrics;

namespace BakeryApp.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Category>? Categories{ get; set; }
        public IEnumerable<Product>? Products { get; set; }
    }
}
