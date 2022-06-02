namespace Application.BusinessLogic.ShippingCost
{
    public class ShippingCost : IShippingCost
    {
        private const double shippingCostFactor = 50.00;
        private const double lowerCost = 10;
        private const double higherCost = 20;

        public async Task<double> CalculateShippingCostAsync(double totalBasketCost)
        {
            if (totalBasketCost < shippingCostFactor)
            {
                return await Task.FromResult(lowerCost);
            }
            return higherCost;
        }
    }
}
