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

        [Fact(Skip = "The Checkout API can only be used by Sales Channel apps.")]
        public Task Creates_Checkouts()
        {
            return Task.CompletedTask;
        }

        [Fact(Skip = "The Checkout API can only be used by Sales Channel apps.")]
        public Task Completes_Checkouts()
        {
            return Task.CompletedTask;
        }

        [Fact(Skip = "The Checkout API can only be used by Sales Channel apps.")]
        public Task Gets_Checkouts()
        {
            return Task.CompletedTask;
        }

        [Fact(Skip = "The Checkout API can only be used by Sales Channel apps.")]
        public Task Updates_Checkouts()
        {
            return Task.CompletedTask;
        }

        [Fact(Skip = "The Checkout API can only be used by Sales Channel apps.")]
        public Task Lists_Checkout_Shipping_Rates()
        {
            return Task.CompletedTask;
        }
    }
}
