using Shop.Models;
using Shop.Models.Dtos;

namespace Shop.Service.OrderService
{
    public interface IOrderService
    {
        Task<Order> GetByIdAsync(Guid id);
        Task CreateAsync(OrderRequestDTO newOrder);
        Task<List<Order>> GetAllAsync();
        Task UpdateAsync(Guid id, OrderRequestDTO orderToUpdate);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<OrderSummaryDto>> GetOrdersSummaryAsync();
    }


}
