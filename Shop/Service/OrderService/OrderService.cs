using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;
using Shop.Models.Dtos;
using Shop.Repositories.OrderRepository;

namespace Shop.Service.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ApplicationDbContext _context;

        public OrderService(IOrderRepository orderRepository, ApplicationDbContext context)
        {
            _orderRepository = orderRepository;
            _context = context;
        }

        public async Task CreateAsync (OrderRequestDTO newOrder)

        {             var order = new Order
        {
                OrderDate = DateTime.Now,
                
            };
                   await _orderRepository.CreateAsync(order);
               }

        public async Task DeleteAsync( Guid id)
        {
            var order = await _orderRepository.FindByIdAsync(id);
            _orderRepository.Delete(order);
            await _orderRepository.SaveAsync();
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return (await _orderRepository.GetAllAsync()).ToList();
        }

        public async Task<Order> GetByIdAsync(Guid id)
        {
            return await _orderRepository.FindByIdAsync(id);
        }

        public async Task UpdateAsync( Guid id, OrderRequestDTO orderToUpdate)
        {
            var order = await _orderRepository.FindByIdAsync(id);
            order.OrderDate = orderToUpdate.OrderDate;
            await _orderRepository.SaveAsync();
        }

        public async Task<IEnumerable<OrderSummaryDto>> GetOrdersSummaryAsync()
        {
            return await _context.Orders
                .Include(o => o.ProductOrders)
                .ThenInclude(po => po.Product)
                .GroupBy(o => o.OrderDate.Date)
                .Select(group => new OrderSummaryDto
                {
                    OrderDate = group.Key,
                    TotalAmount = group.SelectMany(o => o.ProductOrders)
                                       .Sum(po => po.Product.Price),
                    OrderCount = group.Count(),
                    ProductCount = group.SelectMany(o => o.ProductOrders).Count()
                })
                .ToListAsync();
        }



    }

}
