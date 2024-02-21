using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;
using Shop.Repositories.GenericRepository;

namespace Shop.Repositories.ProductOrderRepository
{
    public class ProductOrderRepository : GenericRepository<ProductOrder>, IProductOrderRepository
    {
        public ProductOrderRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ProductOrder>> GetAllProductOrdersAsync()
        {
            return await GetAllAsync();
        }

        public async Task<IEnumerable<ProductOrder>> FindProductOrdersByOrderIdAsync(Guid orderId)
        {
            return await _table.Where(po => po.OrderId == orderId).ToListAsync();
        }
    }

}
