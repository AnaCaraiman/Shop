using Shop.Models;
using Shop.Repositories.ProductDetailRepository;

namespace Shop.Service.ProductDetailService
{
    public class ProductDetailService : IProductDetailService
    {
        private readonly IProductDetailRepository _productDetailsRepository;

        public ProductDetailService(IProductDetailRepository productDetailsRepository)
        {
            _productDetailsRepository = productDetailsRepository;
        }

        public async Task CreateAsync(ProductDetail newProductDetails)
        {
            await _productDetailsRepository.CreateAsync(newProductDetails);
            await _productDetailsRepository.SaveAsync();
        }

        public async Task DeleteAsync(ProductDetail productDetailsToDelete)
        {
            _productDetailsRepository.Delete(productDetailsToDelete);
            await _productDetailsRepository.SaveAsync();
        }

        public async Task<List<ProductDetail>> GetAllAsync()
        {
            return (await _productDetailsRepository.GetAllAsync()).ToList();
        }
            
        public async Task<ProductDetail> GetByIdAsync(Guid id)
        {
            return await _productDetailsRepository.FindByIdAsync(id);
        }

        public async Task UpdateAsync(ProductDetail productDetailsToUpdate)
        {
            _productDetailsRepository.Update(productDetailsToUpdate);
            await _productDetailsRepository.SaveAsync();
        }
        
    }
}
