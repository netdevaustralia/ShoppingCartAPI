using Application.ProductList.Queries;
using MediatR;

namespace Application.Basket.Commands
{
    public record CreateBasketCommand : IRequest<int>
    {
        public IList<ProductDto> Products { get; set; } = new List<ProductDto>();
        public double ShippingCost { get; set; }
        public double ItemsCost { get; set; }

        public class CreateBasketCommandHAndler : IRequestHandler<CreateBasketCommand, int>
        {
            public async Task<int> Handle(CreateBasketCommand request, CancellationToken cancellationToken)
            {
                return await Task.FromResult(1);
            }
        }
    }
}
