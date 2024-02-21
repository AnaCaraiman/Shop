using Shop.Models;
using Shop.Models.Dtos;
using Shop.Repositories.ProductRepository;

namespace Shop.Service.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        
        public async Task CreateAsync(ProductRequestDTO newProduct)
        {
            var product = new Product
            {
                Name = newProduct.Name,
                Price = newProduct.Price,
                CategoryId = newProduct.CategoryId
            };
        }

        
        public async Task DeleteAsync(Guid id)
        {
            var product = await _productRepository.FindByIdAsync(id);
            _productRepository.Delete(product);
            await _productRepository.SaveAsync();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return (await _productRepository.GetAllAsync()).ToList();
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            return await _productRepository.FindByIdAsync(id);
        }

        
        public async Task UpdateAsync(Guid id, ProductRequestDTO productToUpdate)
        {
            var product = await _productRepository.FindByIdAsync(id);
            product.Name = productToUpdate.Name;
            product.Price = productToUpdate.Price;
            product.CategoryId = productToUpdate.CategoryId;
            _productRepository.Update(product);
            await _productRepository.SaveAsync();
        }
    }

}
