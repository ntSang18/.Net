using System.ComponentModel.DataAnnotations;
namespace ProductManager.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(256)]
        public String Name { get; set; }

        [MaxLength(256)]
        public String? Slug { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}