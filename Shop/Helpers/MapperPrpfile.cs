using AutoMapper;
using Shop.Models;
using Shop.Models.Dtos;

namespace Shop.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Category, CategoryRequestDTO >();
            CreateMap<CategoryRequestDTO, Category>();
            CreateMap<Product, ProductRequestDTO>();
            CreateMap<ProductRequestDTO, Product>();
            CreateMap<Order, OrderRequestDTO>();
            CreateMap<OrderRequestDTO, Order>();
            CreateMap<ProductOrder, ProductOrderRequestDTO>();
            CreateMap<ProductOrderRequestDTO, ProductOrder>();
            CreateMap<ProductDetail, ProductDetailsRequestDTO>();
            CreateMap<ProductDetailsRequestDTO, ProductDetail>();
        }
    }
}
