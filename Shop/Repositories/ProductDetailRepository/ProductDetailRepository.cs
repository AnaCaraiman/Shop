using Shop.Data;
using Shop.Models;
using Shop.Repositories.GenericRepository;

namespace Shop.Repositories.ProductDetailRepository
{
    public class ProductDetailRepository : GenericRepository<ProductDetail>, IProductDetailRepository
    {
        public ProductDetailRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ProductDetail>> GetAllProductDetailAsync()
        {
            return await GetAllAsync();
        }

        public async Task<ProductDetail> FindProductDetailByProductIdAsync(Guid productId)
        {
            return await FindSingleOrDefaultAsync(pd => pd.ProductId == productId);
        }
    }

}
