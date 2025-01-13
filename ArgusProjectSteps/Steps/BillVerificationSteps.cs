using ArgusProjectSteps.Context;
using FluentAssertions;

namespace ArgusProjectSteps.Steps
{
    [Binding]
    public class BillVerificationSteps
    {
        private readonly OrderContext orderContext;

        public BillVerificationSteps(OrderContext orderContext)
        {
            this.orderContext = orderContext;
        }

        [Then(@"The total returned should be ""(.*)""")]
        public void ThenTheTotalReturnedShouldBe(decimal expectedTotal)
        {
            orderContext.Total.Should().Be(expectedTotal);
        }
    }
}
