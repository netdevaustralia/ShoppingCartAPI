using FluentValidation;

namespace Application.Basket.Commands
{
    public class CreateBasketCommandValidator : AbstractValidator<CreateBasketCommand>
    {
        public CreateBasketCommandValidator()
        {
            RuleFor(x => x.ShippingCost).GreaterThan(0);
            RuleFor(x => x.ItemsCost).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Products).NotEmpty();
        }
    }
}
