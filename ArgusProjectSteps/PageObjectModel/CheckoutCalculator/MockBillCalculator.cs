namespace ArgusProjectSteps.PageObjectModel.CheckoutCalculator
{
    public class MockBillCalculator
    {
        private readonly MockCheckoutSystem orderContext;

        public MockBillCalculator(MockCheckoutSystem orderContext)
        {
            this.orderContext = orderContext;
        }

        private const decimal starterCost = 4;
        private const decimal mainCost = 7;
        private const decimal fullDrinkCost = 2.5M;
        private const decimal drinkDiscount = 0.7M;
        private const decimal serviceCharge = 0.1M;

        public decimal CalculateBill()
        {
            decimal runningTotal = 0.00M;

            runningTotal += orderContext.Starters * starterCost;

            runningTotal += orderContext.Mains * mainCost;

            runningTotal += orderContext.DiscountDrinks * fullDrinkCost * drinkDiscount;

            runningTotal += orderContext.FullPriceDrinks * fullDrinkCost;

            runningTotal *= 1 + serviceCharge;

            return runningTotal;
        }
    }
}
