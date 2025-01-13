using ArgusProjectSteps.Context;

namespace ArgusProjectSteps.Steps
{
    [Binding]
    public class OrderingSteps
    {
        private readonly OrderContext orderContext;

        public OrderingSteps(OrderContext orderContext)
        {
            this.orderContext = orderContext;
        }

        [Given(@"""(.*)"" starter is ordered")]
        [Given(@"""(.*)"" starters are ordered")]
        public void GivenStartersAreOrdered(int starterOrders)
        {
            orderContext.Starters += starterOrders;
        }

        [Given(@"""(.*)"" main is ordered")]
        [Given(@"""(.*)"" mains are ordered")]
        public void GivenMainsAreOrdered(int mainOrders)
        {
            orderContext.Mains += mainOrders;
        }

        [Given(@"""(.*)"" drink is ordered after the cutoff period")]
        [Given(@"""(.*)"" drinks are ordered after the cutoff period")]
        public void GivenDrinksAreOrderedAfterCutoff(int drinkOrders)
        {
            orderContext.FullPriceDrinks += drinkOrders;
        }

        [Given(@"""(.*)"" drink is ordered before the cutoff period")]
        [Given(@"""(.*)"" drinks are ordered before the cutoff period")]
        public void GivenDrinksAreOrderedBeforeCutoff(int drinkOrders)
        {
            orderContext.DiscountDrinks += drinkOrders;
        }

        [When(@"""(.*)"" starter is removed")]
        [When(@"""(.*)"" starters are removed")]
        public void WhenStarterIsRemoved(int startOrders)
        {
            orderContext.Starters -= startOrders;
        }

        [When(@"""(.*)"" main is removed")]
        [When(@"""(.*)"" mains are removed")]
        public void WhenMainIsRemoved(int mainOrders)
        {
            orderContext.Mains -= mainOrders;
        }

        [When(@"""(.*)"" drink from after the cutoff period is removed")]
        [When(@"""(.*)"" drinks from after the cutoff period are removed")]
        public void WhenDrinkFromAfterTheCutoffPeriodIsRemoved(int drinkOrders)
        {
            orderContext.FullPriceDrinks -= drinkOrders;
        }

    }
}
