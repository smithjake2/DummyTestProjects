using ArgusProjectSteps.Context;
using ArgusProjectSteps.PageObjectModel.CheckoutCalculator;

namespace ArgusProjectSteps.Steps
{
    [Binding]
    public class BillCalculationSteps
    {
        private readonly OrderContext orderContext;
        private readonly MockBillCalculator billCalculator;

        public BillCalculationSteps(OrderContext orderContext, MockBillCalculator billCalculator)
        {
            this.orderContext = orderContext;
            this.billCalculator = billCalculator;
        }

        [When(@"The total bill is calculated")]
        public void WhenTheTotalBillIsCalculated()
        {
            orderContext.Total = billCalculator.CalculateBill(); // MOCKED Calculator
        }

    }
}
