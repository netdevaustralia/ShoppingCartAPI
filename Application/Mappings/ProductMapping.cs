using AutoMapper;

namespace Application.Mappings
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Domain.Entities.Product, Application.ProductList.Queries.ProductDto>();
            CreateMap<Domain.Entities.ProductList, Application.ProductList.Queries.ProductsVm>();
        }
    }
}
