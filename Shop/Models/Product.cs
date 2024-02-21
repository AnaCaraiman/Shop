using Shop.Base;

namespace Shop.Models
{
    public class Product: BaseEntity
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public ProductDetail ProductDetail { get; set; } 
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
