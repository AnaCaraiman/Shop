using Shop.Models;
using Shop.Repositories.ProductOrderRepository;

namespace Shop.Service.ProductOrderService
{
    public class ProductOrderService : IProductOrderService
    {

        private readonly IProductOrderRepository _productOrderRepository;

        public ProductOrderService(IProductOrderRepository productOrderRepository)
        {
            _productOrderRepository = productOrderRepository;
        }

        public async Task CreateAsync(ProductOrder newProductOrder)
        {
            await _productOrderRepository.CreateAsync(newProductOrder);
            await _productOrderRepository.SaveAsync();
        }

        public async Task DeleteAsync(ProductOrder productOrderToDelete)
        {
            _productOrderRepository.Delete(productOrderToDelete);
            await _productOrderRepository.SaveAsync();
        }

        public async Task<List<ProductOrder>> GetAllAsync()
        {
            return (await _productOrderRepository.GetAllAsync()).ToList();
        }
        public async Task<ProductOrder> GetByIdAsync(Guid id)
        {
            return await _productOrderRepository.FindByIdAsync(id);
        }
        public async Task UpdateAsync(ProductOrder productOrderToUpdate)
        {
            _productOrderRepository.Update(productOrderToUpdate);
            await _productOrderRepository.SaveAsync();
        }

    }
}
