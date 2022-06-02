using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.ProductList.Queries
{
    public record GetProductsQuery : IRequest<ProductsVm>;
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, ProductsVm>
    {
        private readonly IMapper _mapper;
        public GetProductsQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ProductsVm> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            //Ideally the product list should be coming from the context db but due to the time constraints it is hardcoded.
            Domain.Entities.ProductList? productList = new Domain.Entities.ProductList
            {
                Products = new List<Product> {
                    new Product
                    {
                        Id = 1,
                        Currency = "AUD",
                        Title = "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet",
                        Price = 899,
                        Category="jewelery",
                        Image="https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg",
                        Description="From our Legends Collection, the Naga was inspired by the mythical water dragon that protects the ocean's pearl"
                    },
                    new Product
                    {
                        Id = 2,
                        Currency = "AUD",
                        Title = "Solid Gold Petite Micropave",
                        Price = 100,
                         Category="jewelery",
                         Image="https://fakestoreapi.com/img/71YAIFU48IL._AC_UL640_QL65_ML3_.jpg",
                         Description="Classic Created Wedding Engagement Solitaire Diamond Promise Ring for Her. Gifts to spoil your love more for Engagement, Wedding, Anniversary, Valentine's Day..."
                    },
                    new Product
                    {
                        Id = 3,
                        Currency = "AUD",
                        Title = "Pierced Owl Rose Gold Plated Stainless Steel Double",
                        Price = 49.99,
                         Category="jewelery",
                         Image="https://fakestoreapi.com/img/51UDEzMJVpL._AC_UL640_QL65_ML3_.jpg",
                         Description="Rose Gold Plated Double Flared Tunnel Plug Earrings. Made of 316L Stainless Steel"
                    }
                }
            };

            ProductsVm? list = await Task.FromResult(_mapper.Map<ProductsVm>(productList));
            return list;
        }
    }
}
