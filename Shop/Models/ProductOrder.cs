using Shop.Base;

namespace Shop.Models
{
    public class ProductOrder : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}
