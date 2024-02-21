using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Models.Dtos;
using Shop.Service.OrderService;
using Shop.Service.ProductOrderService;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IProductOrderService _productOrderService;

        public OrderController(IOrderService orderService, IProductOrderService productOrderService)
        {
            _orderService = orderService;
            _productOrderService = productOrderService;
        }

        // GET: api/Order
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _orderService.GetAllAsync();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(Guid id)
        {
            var order = await _orderService.GetByIdAsync(id);
            if (order == null) return NotFound();
             return Ok(order);
        }

      
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderRequestDTO orderDto)
        {
            await _orderService.CreateAsync(orderDto);
            return StatusCode(201);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(Guid id, [FromBody] OrderRequestDTO orderDto)
        {
            await _orderService.UpdateAsync(id, orderDto);
            return NoContent();
        }

     
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(Guid id)
        {
            await _orderService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("summary")]
        public async Task<IActionResult> GetOrdersSummary()
        {
            var orderSummary = await _orderService.GetOrdersSummaryAsync();
            return Ok(orderSummary);
        }
    }
}
