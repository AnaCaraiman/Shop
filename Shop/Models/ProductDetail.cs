using Shop.Base;

namespace Shop.Models
{
    public class ProductDetail : BaseEntity
    {
        public Guid ProductDetailId { get; set; }
        public string Description { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
