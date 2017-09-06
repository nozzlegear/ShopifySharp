using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Charge")]
    public class Charge_Tests
    {
        private ChargeService _Service => new ChargeService(Utils.MyShopifyUrl, Utils.AccessToken);

        [Fact(Skip = "Charges cannot be tested with a private application.")]
        public void Creates_Charges()
        {
            // Can't be tested.
        }

        [Fact(Skip = "Charges cannot be tested with a private application.")]
        public void Activates_Charges()
        {
            // Can't be tested.
        }

        [Fact(Skip = "Charges cannot be tested with a private application.")]
        public void Lists_Charges()
        {
            // Can't be tested.
        }

        [Fact(Skip = "Charges cannot be tested with a private application.")]
        public void Gets_Charges()
        {
            // Can't be tested.
        }
    }
}