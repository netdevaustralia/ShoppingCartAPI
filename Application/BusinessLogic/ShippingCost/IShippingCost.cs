namespace Application.BusinessLogic.ShippingCost
{
    public interface IShippingCost
    {
        Task<double> CalculateShippingCostAsync(double totalBasketCost);
    }
}
