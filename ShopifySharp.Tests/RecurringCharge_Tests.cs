using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "RecurringCharge")]
    public class RecurringCharge_Tests
    {
        RecurringChargeService Service { get; } = new RecurringChargeService(Utils.MyShopifyUrl, Utils.AccessToken);

        public RecurringCharge_Tests()
        {
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());
        }

        [Fact(Skip = "Recurring charges cannot be tested with a private application.")]
        public void Creates_Charges()
        {
            // Can't be tested.
        }

        [Fact(Skip = "Recurring charges cannot be tested with a private application.")]
        public void Activates_Charges()
        {
            // Can't be tested.
        }

        [Fact(Skip = "Recurring charges cannot be tested with a private application.")]
        public void Lists_Charges()
        {
            // Can't be tested.
        }

        [Fact(Skip = "Recurring charges cannot be tested with a private application.")]
        public void Gets_Charges()
        {
            // Can't be tested.
        }

        [Fact(Skip = "Recurring charges cannot be tested with a private application.")]
        public void Deletes_Charges()
        {
            // Can't be tested.    
        }
    }
}