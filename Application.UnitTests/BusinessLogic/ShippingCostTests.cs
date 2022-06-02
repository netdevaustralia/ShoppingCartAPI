using Application.BusinessLogic.ShippingCost;
using FluentAssertions;

namespace Application.UnitTests.BusinessLogic
{
    public class ShippingCostTests
    {
        [Theory]
        [InlineData(100, 20)]
        [InlineData(40, 10)]
        public async Task CalculateShippingCost_WithBasketCost_ReturnsCorrectResult(double basketCost, double expectedShippingCost)
        {
            //Arrange
            ShippingCost? shippingCostLogic = new ShippingCost();

            //Act
            double shippingCost = await shippingCostLogic.CalculateShippingCostAsync(basketCost);

            //Assert
            shippingCost.Should().Be(expectedShippingCost);
        }
    }
}