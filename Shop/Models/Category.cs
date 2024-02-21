using Shop.Base;
namespace Shop.Models
{
    public class Category : BaseEntity   
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
