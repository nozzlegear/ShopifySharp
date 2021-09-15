using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Checkout")]
    public class Checkout_Tests
    {
        CheckoutService Service { get; } = new CheckoutService(Utils.MyShopifyUrl, Utils.AccessToken);

        public Checkout_Tests()
        {
            Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
        }

        [Fact]
        public async Task Lists_Checkouts()
        {
            var list = await Service.ListAsync();
            
            Assert.NotNull(list);
            Assert.NotNull(list.Items);
        }

        [Fact]
        public async Task Counts_Checkouts()
        {
            var count = await Service.CountAsync();
            
            Assert.True(count >= 0);
        }

        [Fact(Skip = "You can't use the Checkout API to create a new checkout user experience for an individual store.")]
        public async Task Creates_Checkouts()
        {
            
        }

        [Fact(Skip = "You can't use the Checkout API to create a new checkout user experience for an individual store.")]
        public async Task Completes_Checkouts()
        {

        }

        [Fact(Skip = "You can't use the Checkout API to create a new checkout user experience for an individual store.")]
        public async Task Gets_Checkouts()
        {

        }

        [Fact(Skip = "You can't use the Checkout API to create a new checkout user experience for an individual store.")]
        public async Task Updates_Checkouts()
        {

        }

        [Fact(Skip = "You can't use the Checkout API to create a new checkout user experience for an individual store.")]
        public async Task Lists_Checkout_Shipping_Rates()
        {

        }
    }
}
