using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "UsageCharge")]
    public class UsageCharge_Tests
    {
        private UsageChargeService _Service => new UsageChargeService(Utils.MyShopifyUrl, Utils.AccessToken);

        public UsageCharge_Tests()
        {

        }

        [Fact(Skip = "Usage charges cannot be tested with a private application.")]
        public void Creates_Charges()
        {
            // Can't be tested.
        }

        [Fact(Skip = "Usage charges cannot be tested with a private application.")]
        public void Activates_Charges()
        {
            // Can't be tested.
        }

        [Fact(Skip = "Usage charges cannot be tested with a private application.")]
        public void Lists_Charges()
        {
            // Can't be tested.
        }

        [Fact(Skip = "Usage charges cannot be tested with a private application.")]
        public void Gets_Charges()
        {
            // Can't be tested.
        }

        [Fact(Skip = "Usage charges cannot be tested with a private application.")]
        public void Deletes_Charges()
        {
            // Can't be tested.    
        }
    }
}