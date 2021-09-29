using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Retry policies")]
    public class RetryExecutionPolicies_Tests
    {
        private OrderService OrderService { get; } = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);

        private Order Order = new Order()
        {
            LineItems = new List<LineItem>()
            {
                new LineItem()
                {
                    Name = "Test Line Item",
                    Title = "Test Line Item Title",
                    Quantity = 2,
                    Price = 5
                }
            },
            TotalPrice = 5.00m,
            Test = true
        };

        [Fact]
        public async Task NonLeakyBucketBreachShouldNotAttemptRetry()
        {
            OrderService.SetExecutionPolicy(new SmartRetryExecutionPolicy());
            bool caught = false;
            try
            {
                //trip the 5 orders per minute limit on dev stores
                foreach (var i in Enumerable.Range(0, 10))
                {
                    await OrderService.CreateAsync(this.Order);
                }
            }
            catch (ShopifyRateLimitException ex)
            {
                caught = true;
                Assert.True(ex.Reason != ShopifyRateLimitReason.BucketFull);
            }
            Assert.True(caught);
        }

        [Fact]
        public async Task NonLeakyBucketBreachShouldRetryWhenConstructorBoolIsFalse()
        {
            OrderService.SetExecutionPolicy(new SmartRetryExecutionPolicy(false));
            
            bool caught = false;
            
            try
            {
                //trip the 5 orders per minute limit on dev stores
                foreach (var i in Enumerable.Range(0, 10))
                {
                    await OrderService.CreateAsync(this.Order);
                }
            }
            catch (ShopifyRateLimitException)
            {
                caught = true;
            }
            
            Assert.False(caught);
        }

        [Fact]
        public async Task LeakyBucketBreachShouldAttemptRetry()
        {
            OrderService.SetExecutionPolicy(new SmartRetryExecutionPolicy());
            
            bool caught = false;
            
            try
            {
                //trip the 40/seconds bucket limit
                await Task.WhenAll(Enumerable.Range(0, 45).Select(async _ => await OrderService.ListAsync()));
            }
            catch (ShopifyRateLimitException)
            {
                caught = true;
            }
            
            Assert.False(caught);
        }
    }
}
