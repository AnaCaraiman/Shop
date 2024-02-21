using Shop.Models;

namespace Shop.Service.ProductDetailService
{
    public interface IProductDetailService
    {
        Task<ProductDetail> GetByIdAsync(Guid id);
        Task CreateAsync(ProductDetail newProductDetails);
        Task<List<ProductDetail>> GetAllAsync();
        Task UpdateAsync(ProductDetail productDetailsToUpdate);
        Task DeleteAsync(ProductDetail productDetailsToDelete);
    }
}
