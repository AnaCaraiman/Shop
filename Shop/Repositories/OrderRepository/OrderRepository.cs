using Shop.Data;
using Shop.Models;
using Shop.Repositories.GenericRepository;

namespace Shop.Repositories.OrderRepository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await GetAllAsync();
        }

        public async Task<Order> FindOrderByIdAsync(Guid orderId)
        {
            return await FindByIdAsync(orderId);
        }
    }

}
