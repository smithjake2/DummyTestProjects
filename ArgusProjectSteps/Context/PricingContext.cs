namespace ArgusProjectSteps.Context
{
    public class PricingContext
    {
        public decimal Starter { get; set; }

        public decimal Main { get; set; }

        public decimal FullDrink { get; set; }

        public decimal DrinkDiscount { get; set; }

        public decimal ServiceCharge { get; set; }

        public decimal DiscountedDrink => FullDrink * DrinkDiscount;
    }
}
