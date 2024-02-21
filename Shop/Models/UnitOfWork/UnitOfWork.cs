using Microsoft.Data.SqlClient;
using Shop.Data;
using Shop.Repositories.CategoryRepository;
using Shop.Repositories.OrderRepository;
using Shop.Repositories.ProductDetailRepository;
using Shop.Repositories.ProductOrderRepository;
using Shop.Repositories.ProductRepository;

namespace Shop.Models.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork 
    {
        public ICategoryRepository CategoryRepository { get; private set; }
        public IProductRepository ProductRepository { get; private set; }
        public IOrderRepository OrderRepository { get; private set; }
        public IProductOrderRepository ProductOrderRepository { get; private set; }
        public IProductDetailRepository ProductDetailRepository { get; private set; }

        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            CategoryRepository = new CategoryRepository(_context);
            ProductRepository = new ProductRepository(_context);
            OrderRepository = new OrderRepository(_context);
            ProductOrderRepository = new ProductOrderRepository(_context);
            ProductDetailRepository = new ProductDetailRepository(_context);
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
