using Application.BusinessLogic.ShippingCost;
using MediatR;

namespace Application.Basket.Queries
{
    public record GetShippingCostQuery : IRequest<double>
    {
        public double TotalBasketCost { get; set; }
    }

    public class GetShippingCostQueryHandler : IRequestHandler<GetShippingCostQuery, double>
    {
        private readonly IShippingCost _shippingCost;
        public GetShippingCostQueryHandler(IShippingCost shippingCost)
        {
            _shippingCost = shippingCost;
        }

        public async Task<double> Handle(GetShippingCostQuery request, CancellationToken cancellationToken)
        {
            return await _shippingCost.CalculateShippingCostAsync(request.TotalBasketCost);
        }
    }

}
