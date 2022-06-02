using Application.Basket.Commands;
using Application.Basket.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCartApi.Controllers
{
    public class BasketController : ApiControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateBasketCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet("getShippingCost")]
        public async Task<ActionResult<double>> CalculateShippingCost(double totalCost)
        {
            return await Mediator.Send(new GetShippingCostQuery { TotalBasketCost = totalCost });
        }
    }
}
