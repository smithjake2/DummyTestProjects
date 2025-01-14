using ArgusProjectSteps.Context;
using ArgusProjectSteps.PageObjectModel.CheckoutCalculator;

namespace ArgusProjectSteps.Steps
{
    [Binding]
    public class OrderingSteps
    {
        private readonly MockCheckoutSystem mockCheckoutSystem;
        private readonly OrderContext orderContext;

        public OrderingSteps(MockCheckoutSystem mockCheckoutSystem, OrderContext orderContext)
        {
            this.mockCheckoutSystem = mockCheckoutSystem;
            this.orderContext = orderContext;
        }

        [Given(@"""(.*)"" starter is ordered")]
        [Given(@"""(.*)"" starters are ordered")]
        public void GivenStartersAreOrdered(int starterOrders)
        {
            mockCheckoutSystem.Starters += starterOrders; // MOCKED: Interaction with Checkout System to change order
            orderContext.Starters += starterOrders;
            
        }

        [Given(@"""(.*)"" main is ordered")]
        [Given(@"""(.*)"" mains are ordered")]
        public void GivenMainsAreOrdered(int mainOrders)
        {
            mockCheckoutSystem.Mains += mainOrders; // MOCKED: Interaction with Checkout System to change order
            orderContext.Mains += mainOrders;
        }

        [Given(@"""(.*)"" drink is ordered after the cutoff period")]
        [Given(@"""(.*)"" drinks are ordered after the cutoff period")]
        public void GivenDrinksAreOrderedAfterCutoff(int drinkOrders)
        {
            mockCheckoutSystem.FullPriceDrinks += drinkOrders; // MOCKED: Interaction with Checkout System to change order
            orderContext.FullPriceDrinks += drinkOrders;
        }

        [Given(@"""(.*)"" drink is ordered before the cutoff period")]
        [Given(@"""(.*)"" drinks are ordered before the cutoff period")]
        public void GivenDrinksAreOrderedBeforeCutoff(int drinkOrders)
        {
            mockCheckoutSystem.DiscountDrinks += drinkOrders; // MOCKED: Interaction with Checkout System to change order
            orderContext.DiscountDrinks += drinkOrders;
        }

        [When(@"""(.*)"" starter is removed")]
        [When(@"""(.*)"" starters are removed")]
        public void WhenStarterIsRemoved(int startOrders)
        {
            mockCheckoutSystem.Starters -= startOrders; // MOCKED: Interaction with Checkout System to change order
            orderContext.Starters -= startOrders;
        }

        [When(@"""(.*)"" main is removed")]
        [When(@"""(.*)"" mains are removed")]
        public void WhenMainIsRemoved(int mainOrders)
        {
            mockCheckoutSystem.Mains -= mainOrders; // MOCKED: Interaction with Checkout System to change order
            orderContext.Mains -= mainOrders;
        }

        [When(@"""(.*)"" drink from after the cutoff period is removed")]
        [When(@"""(.*)"" drinks from after the cutoff period are removed")]
        public void WhenDrinkFromAfterTheCutoffPeriodIsRemoved(int drinkOrders)
        {
            mockCheckoutSystem.FullPriceDrinks -= drinkOrders; // MOCKED: Interaction with Checkout System to change order
            orderContext.FullPriceDrinks -= drinkOrders;
        }

        [Given(@"I use the json parser")]
        public void GivenIUseTheJsonParser()
        {
            var pricingParser = new PricingParser();
            var pricingContext = pricingParser.GetJSON();
            var starterPrice = pricingContext.Starter;
        }


    }
}
