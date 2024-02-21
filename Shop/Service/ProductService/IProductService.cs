using Shop.Models;
using Shop.Models.Dtos;

namespace Shop.Service.ProductService
{
    public interface IProductService
    {
        Task<Product> GetByIdAsync(Guid id);
        Task CreateAsync(ProductRequestDTO newProduct);
        Task<List<Product>> GetAllAsync();
        Task UpdateAsync(Guid id, ProductRequestDTO productToUpdate);
        Task DeleteAsync(Guid id);
    }
}
