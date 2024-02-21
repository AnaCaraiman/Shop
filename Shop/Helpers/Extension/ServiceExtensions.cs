using Shop.Repositories.CategoryRepository;
using Shop.Repositories.OrderRepository;
using Shop.Repositories.ProductDetailRepository;
using Shop.Repositories.ProductOrderRepository;
using Shop.Repositories.ProductRepository;
using Shop.Service.CategoryService;
using Shop.Service.OrderService;
using Shop.Service.ProductDetailService;
using Shop.Service.ProductOrderService;
using Shop.Service.ProductService;

namespace Shop.Helpers.Extension
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IProductDetailRepository, ProductDetailRepository>();
            services.AddTransient<IProductOrderRepository, ProductOrderRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IProductDetailService, ProductDetailService>();
            services.AddTransient<IProductOrderService, ProductOrderService>();
            services.AddTransient<ICategoryService, CategoryService>();
            return services;
        }
    }
}
