namespace BakeryApp.Models
{
    public class ProductCategoriesVM
    {
        public IEnumerable<Category>? Categories { get; set; }
        public Product? Product { get; set; }
    }
}
