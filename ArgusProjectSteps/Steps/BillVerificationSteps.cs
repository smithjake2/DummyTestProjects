using ArgusProjectSteps.Context;
using ArgusProjectSteps.PageObjectModel.CheckoutCalculator;
using FluentAssertions;

namespace ArgusProjectSteps.Steps
{
    [Binding]
    public class BillVerificationSteps
    {
        private readonly MockCheckoutSystem mockCheckoutSystem;
        private readonly OrderContext orderContext;

        public BillVerificationSteps(MockCheckoutSystem mockCheckoutSystem, OrderContext orderContext)
        {
            this.mockCheckoutSystem = mockCheckoutSystem;
            this.orderContext = orderContext;
        }

        [Then(@"The total returned should be ""(.*)""")]
        public void ThenTheTotalReturnedShouldBe(decimal expectedTotal)
        {
            mockCheckoutSystem.Total.Should().Be(expectedTotal);
        }

        [Then(@"The total returned should be correct")]
        public void ThenTheTotalReturnedShouldBeCorrect()
        {
            var expectedTotal = CalculateExpectedPrice();

            ThenTheTotalReturnedShouldBe(expectedTotal);
        }

        private decimal CalculateExpectedPrice()
        {
            var pricingParser = new PricingParser();
            var pricingContext = pricingParser.GetJSON();

            var totalStarterPrice = orderContext.Starters * pricingContext.Starter;
            var totalMainPrice = orderContext.Mains * pricingContext.Main;
            var totalDrinksPrice = orderContext.FullPriceDrinks * pricingContext.FullDrink + orderContext.DiscountDrinks * pricingContext.DiscountedDrink;

            var subTotal = totalStarterPrice + totalMainPrice + totalDrinksPrice;

            var serviceCharge = subTotal * pricingContext.ServiceCharge;

            return subTotal + serviceCharge;
        }
    }
}
