using Shop.Models;

namespace Shop.Service.ProductOrderService
{
    public interface IProductOrderService
    {
        Task<ProductOrder> GetByIdAsync(Guid id);
        Task CreateAsync(ProductOrder newProductOrder);
        Task<List<ProductOrder>> GetAllAsync();
        Task UpdateAsync(ProductOrder productOrderToUpdate);
        Task DeleteAsync(ProductOrder productOrderToDelete);
    }

}
