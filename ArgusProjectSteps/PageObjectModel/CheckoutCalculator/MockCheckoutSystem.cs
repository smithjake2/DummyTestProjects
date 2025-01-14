namespace ArgusProjectSteps.PageObjectModel.CheckoutCalculator
{
    public class MockCheckoutSystem
    {
        public int Starters { get; set; }

        public int Mains { get; set; }

        public int DiscountDrinks { get; set; }

        public int FullPriceDrinks { get; set; }

        public decimal Total { get; set; }
    }
}
