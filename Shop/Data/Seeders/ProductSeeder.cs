using Shop.Models;

namespace Shop.Data.Seeders
{
    public class ProductSeeder
    {
        private readonly ApplicationDbContext _context;

        public ProductSeeder(ApplicationDbContext context)
        {
            _context = context;
        }

        public void SeedInitialProducts()
        {
            if (!_context.Products.Any())
            {
                var product1 = new Product
                {
                    Name = "Produs 1",
                    Price = 10.99m,
                    
                };

                var product2 = new Product
                {
                    Name = "Produs 2",
                    Price = 15.49m,
                    
                };

                _context.Products.Add(product1);
                _context.Products.Add(product2);

                _context.SaveChanges();
            }
        }
    }
}

