using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Retry policies"), Trait("Category", "DotNetFramework"), Collection("DotNetFramework tests")]
    public class RetryExecutionPolicies_Tests : IClassFixture<RetryExecutionPolicies_Tests_Fixture>
    {
        private readonly Order Order = new Order()
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

        private readonly RetryExecutionPolicies_Tests_Fixture Fixture;

        public RetryExecutionPolicies_Tests(RetryExecutionPolicies_Tests_Fixture fixture)
        {
            Fixture = fixture;
        }

        [Fact]
        public async Task NonFullLeakyBucketBreachShouldNotAttemptRetry()
        {
            Fixture.OrderService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
            bool caught = false;
            try
            {
                //trip the 5 orders per minute limit on dev stores
                foreach (var i in Enumerable.Range(0, 10))
                {
                    await Fixture.OrderService.CreateAsync(this.Order);
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
            Fixture.OrderService.SetExecutionPolicy(new LeakyBucketExecutionPolicy(false));

            bool caught = false;

            try
            {
                //trip the 5 orders per minute limit on dev stores
                foreach (var i in Enumerable.Range(0, 6))
                {
                    await Fixture.OrderService.CreateAsync(this.Order);
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
            Fixture.OrderService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

            bool caught = false;

            try
            {
                //trip the 40/seconds bucket limit
                await Task.WhenAll(Enumerable.Range(0, 45).Select(async _ => await Fixture.OrderService.ListAsync()));
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
            Fixture.GraphService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

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
                await Task.WhenAll(Enumerable.Range(0, 10).Select(async _ => await Fixture.GraphService.PostAsync(query, queryCost)));
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
            var policy = new LeakyBucketExecutionPolicy(getRequestContext: () => context);
            var filter = new Filters.OrderListFilter
            {
                Status = "any",
                Limit = 1,
                Fields = "id"
            };

            DateTime? backgroundCompletedAt = null;
            DateTime? foregroundCompletedAt = null;

            Fixture.OrderService.SetExecutionPolicy(policy);

            //kick off background requests, which will trigger a throttle
            var bgTask = Task.WhenAll(Enumerable.Range(0, 50).Select(async _ => await Fixture.OrderService.ListAsync(filter)))
                .ContinueWith(_ => backgroundCompletedAt = DateTime.UtcNow);

            context = RequestContext.Foreground;

            var fgTask = Task.WhenAll(Enumerable.Range(0, 10).Select(async _ => await Fixture.OrderService.ListAsync(filter)))
                .ContinueWith(_ => foregroundCompletedAt = DateTime.UtcNow);

            await Task.WhenAll(bgTask, fgTask);

            Assert.NotNull(backgroundCompletedAt);
            Assert.NotNull(foregroundCompletedAt);
            Assert.True(foregroundCompletedAt < backgroundCompletedAt);
        }

        [Fact]
        public async Task UnparsableQueryShouldThrowError()
        {
            await Assert.ThrowsAnyAsync<Exception>(async () =>
            {
                Fixture.GraphService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
                string query = "!#@$%$#%";
                await Fixture.GraphService.PostAsync(query, 1);
            });
        }

        [Fact]
        public async Task UnknownFieldShouldThrowError()
        {
            await Assert.ThrowsAnyAsync<Exception>(async () =>
            {
                Fixture.GraphService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
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
                await Fixture.GraphService.PostAsync(query, 1);
            });
        }
    }

    public class RetryExecutionPolicies_Tests_Fixture : IAsyncLifetime
    {
        public readonly OrderService OrderService = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);

        public GraphService GraphService = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken);

        public Task InitializeAsync()
        {
            return Task.CompletedTask;
        }

        public Task DisposeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
