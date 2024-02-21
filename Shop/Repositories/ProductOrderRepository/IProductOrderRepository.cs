using Shop.Models;
using Shop.Repositories.GenericRepository;

namespace Shop.Repositories.ProductOrderRepository
{
    public interface IProductOrderRepository : IGenericRepository<ProductOrder>
    {
        Task<IEnumerable<ProductOrder>> GetAllProductOrdersAsync();
        Task<IEnumerable<ProductOrder>> FindProductOrdersByOrderIdAsync(Guid orderId);
    }

}
