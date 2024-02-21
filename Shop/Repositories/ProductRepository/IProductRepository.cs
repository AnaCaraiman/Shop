using Shop.Models;
using Shop.Repositories.GenericRepository;

namespace Shop.Repositories.ProductRepository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> FindProductByIdAsync(Guid productId);
    }
}
