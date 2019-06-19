using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Discount")]
    public class Discount_Tests
    {
        DiscountService Service { get; } = new DiscountService(Utils.MyShopifyUrl, Utils.AccessToken);

        public Discount_Tests()
        {
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());
        }

        [Fact(Skip = "Shopify Discount API requires a Shopify Plus account, which is difficult to use when testing a lib.")]
        public async Task Creates_An_Application_Credit()
        {
            var created = await Service.CreateAsync(new Discount()
            {
                DiscountType = "fixed_amount",
                Value = "10.00",
                DiscountCode = "AuntieDot",
                MinimumOrderAmount = "40.00",
            });

            Assert.NotNull(created);
        }
    }
}
