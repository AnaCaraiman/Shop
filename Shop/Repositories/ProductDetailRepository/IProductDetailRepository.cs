using Shop.Models;
using Shop.Repositories.GenericRepository;

namespace Shop.Repositories.ProductDetailRepository
{
    public interface IProductDetailRepository : IGenericRepository<ProductDetail>
    {
        Task<IEnumerable<ProductDetail>> GetAllProductDetailAsync();
        Task<ProductDetail> FindProductDetailByProductIdAsync(Guid productId);
    }

}
