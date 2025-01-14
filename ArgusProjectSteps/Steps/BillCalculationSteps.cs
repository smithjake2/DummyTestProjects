using ArgusProjectSteps.PageObjectModel.CheckoutCalculator;

namespace ArgusProjectSteps.Steps
{
    [Binding]
    public class BillCalculationSteps
    {
        private readonly MockCheckoutSystem mockCheckoutSystem;
        private readonly MockBillCalculator billCalculator;

        public BillCalculationSteps(MockCheckoutSystem mockCheckoutSystem, MockBillCalculator billCalculator)
        {
            this.mockCheckoutSystem = mockCheckoutSystem;
            this.billCalculator = billCalculator;
        }

        [When(@"The total bill is calculated")]
        public void WhenTheTotalBillIsCalculated()
        {
            mockCheckoutSystem.Total = billCalculator.CalculateBill(); // MOCKED: Interaction with Checkout System to calculate order
        }

    }
}
