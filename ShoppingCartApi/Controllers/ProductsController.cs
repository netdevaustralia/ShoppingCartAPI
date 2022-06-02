using Application.ProductList.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCartApi.Controllers
{
    public class ProductsController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ProductsVm>> Get()
        {
            return await Mediator.Send(new GetProductsQuery());
        }
    }
}
