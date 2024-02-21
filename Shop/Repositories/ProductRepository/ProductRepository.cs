using Shop.Data;
using Shop.Models;
using Shop.Repositories.GenericRepository;

namespace Shop.Repositories.ProductRepository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await GetAllAsync();
        }

        public async Task<Product> FindProductByIdAsync(Guid productId)
        {
            return await FindByIdAsync(productId);
        }
    }

}
