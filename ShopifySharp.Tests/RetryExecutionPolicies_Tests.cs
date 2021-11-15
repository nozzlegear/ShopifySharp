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
        private GraphService GraphService { get; } = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken);

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
        };

        [Fact]
        public async Task NonFullLeakyBucketBreachShouldNotAttemptRetry()
        {
            OrderService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
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
        public async Task NonFullLeakyBucketBreachShouldRetryWhenConstructorBoolIsFalse()
        {
            OrderService.SetExecutionPolicy(new LeakyBucketExecutionPolicy(false));

            bool caught = false;

            try
            {
                //trip the 5 orders per minute limit on dev stores
                foreach (var i in Enumerable.Range(0, 6))
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
        public async Task LeakyBucketRESTBreachShouldAttemptRetry()
        {
            OrderService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

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

        [Fact]
        public async Task LeakyBucketGraphQLBreachShouldAttemptRetry()
        {
            GraphService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

            bool caught = false;

            try
            {
                int queryCost = 862;
                string query = @"{
  products(first: 20) {
    edges {
      node {
        title
        variants(first:40)
        {
          edges
          {
            node
            {
              title
            }
          }
        }
      }
    }
  }
}
";
                await Task.WhenAll(Enumerable.Range(0, 10).Select(async _ => await GraphService.PostAsync(query, queryCost)));
            }
            catch (ShopifyRateLimitException)
            {
                caught = true;
            }

            Assert.False(caught);
        }


        [Fact]
        public async Task ForegroundRequestsMustRunBeforeBackgroundRequests()
        {
            var context = RequestContext.Background;
            DateTime? backgroundCompletedAt = null;
            DateTime? foregroundCompletedAt = null;


            OrderService.SetExecutionPolicy(new LeakyBucketExecutionPolicy(getRequestContext: () => context));

            //kick off background requests, which will trigger a throttle
            var bgTask = Task.WhenAll(Enumerable.Range(0, 50).Select(async _ => await OrderService.ListAsync()))
                             .ContinueWith(_ => backgroundCompletedAt = DateTime.UtcNow);

            context = RequestContext.Foreground;
            var fgTask = Task.WhenAll(Enumerable.Range(0, 10).Select(async _ => await OrderService.ListAsync(new Filters.OrderListFilter { Status = "any" })))
                             .ContinueWith(_ => foregroundCompletedAt = DateTime.UtcNow);

            await Task.WhenAll(bgTask, fgTask);

            Assert.True(foregroundCompletedAt < backgroundCompletedAt);
        }

        [Fact]
        public async Task UnparsableQueryShouldThrowError()
        {
            await Assert.ThrowsAnyAsync<Exception>(async () =>
            {
                GraphService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
                string query = "!#@$%$#%";
                await GraphService.PostAsync(query, 1);
            });
        }

        [Fact]
        public async Task UnknownFieldShouldThrowError()
        {
            await Assert.ThrowsAnyAsync<Exception>(async () =>
            {
                GraphService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
                string query = @"{
  products(first: 20) {
    edges {
      node {
        title
        variants(first:40)
        {
          edges
          {
            node
            {
              title
              unknown_field
            }
          }
        }
      }
    }
  }
}
";
                await GraphService.PostAsync(query, 1);
            });
        }
    }
}
