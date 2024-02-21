using Shop.Models;

namespace Shop.Data.Seeders
{
    public class OrderSeeder
    {
        private readonly ApplicationDbContext _context;

        public OrderSeeder (ApplicationDbContext context)
        {
            _context = context;
        }

        public void SeedInitialOrders()
        {
            if (!_context.Orders.Any())
            {
                var order1 = new Order
                {
                    OrderDate = DateTime.Now.AddDays(-10),
                
                   
                   
                };

                var order2 = new Order
                {
                    OrderDate = DateTime.Now.AddDays(-5),
                 
                   
                };

                _context.Orders.Add(order1);
                _context.Orders.Add(order2);

                _context.SaveChanges();
            }
        }
    }
}

