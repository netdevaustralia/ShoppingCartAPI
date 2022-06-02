using FluentValidation;

namespace Application.Basket.Queries
{
    public class GetShippingCostQueryValidator : AbstractValidator<GetShippingCostQuery>
    {
        public GetShippingCostQueryValidator()
        {
            RuleFor(x => x.TotalBasketCost).GreaterThan(0);
        }
    }
}
