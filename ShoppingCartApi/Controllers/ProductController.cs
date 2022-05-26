using Application.ProductList.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCartApi.Controllers
{
    public class ProductController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ProductsVm>> GetProducts()
        {
            return await Mediator.Send(new GetProductsQuery());
        }
    }
}
