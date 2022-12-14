namespace ProductManager.Models
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }

        public String Name { get; set; }

        public List<Product> Products { get; set; }
    }
}