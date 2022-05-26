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
            var productList = new Domain.Entities.ProductList
            {
                Products = new List<Product> {
                    new Product
                    {
                        Id = 1,
                        Currency = "AUD",
                        Name = "Chair",
                        Price = 100.23
                    },
                    new Product
                    {
                        Id = 2,
                        Currency = "AUD",
                        Name = "Table",
                        Price = 100.24
                    },
                    new Product
                    {
                        Id = 3,
                        Currency = "AUD",
                        Name = "Laptop",
                        Price = 1000
                    }
                }
            };

            var list = await Task.FromResult(_mapper.Map<ProductsVm>(productList));
            return list;
        }
    }
}
