using Shop.Models;
using Shop.Repositories.GenericRepository;

namespace Shop.Repositories.OrderRepository
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync();
        Task<Order> FindOrderByIdAsync(Guid orderId);
    }
}
