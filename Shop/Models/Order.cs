using Shop.Base;

namespace Shop.Models
{
    public class Order : BaseEntity
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; } = new List<ProductOrder>(); // Partea Many to Many
    }
}

