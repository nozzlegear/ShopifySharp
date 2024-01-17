using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Xunit;
using Xunit.Abstractions;

namespace ShopifySharp.Tests.Policies;

[Trait("Category", "Retry policies"), Trait("Category", "DotNetFramework"), Collection("DotNetFramework tests")]
[TestSubject(typeof(LeakyBucketExecutionPolicy))]
public class LeakyBucketExecutionPolicyTests(ITestOutputHelper testOutputHelper)
{
    private readonly Order _order = new Order()
    {
        LineItems = new List<LineItem>()
        {
            new()
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

    private readonly OrderService _orderService = new(Utils.MyShopifyUrl, Utils.AccessToken);
    private readonly GraphService _graphService = new(Utils.MyShopifyUrl, Utils.AccessToken);

    [Fact]
    public async Task NonFullLeakyBucketBreachShouldNotAttemptRetry()
    {
        _orderService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
        bool caught = false;
        try
        {
            //trip the 5 orders per minute limit on dev stores
            foreach (var _ in Enumerable.Range(0, 10))
            {
                await _orderService.CreateAsync(_order);
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
        _orderService.SetExecutionPolicy(new LeakyBucketExecutionPolicy(false));

        bool caught = false;

        try
        {
            //trip the 5 orders per minute limit on dev stores
            foreach (var _ in Enumerable.Range(0, 6))
            {
                await _orderService.CreateAsync(_order);
            }
        }
        catch (ShopifyRateLimitException)
        {
            caught = true;
        }

        Assert.False(caught);
    }

    [Fact]
    public async Task LeakyBucketRestBreachShouldAttemptRetry()
    {
        _orderService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

        bool caught = false;

        try
        {
            //trip the 40/seconds bucket limit
            await Task.WhenAll(Enumerable.Range(0, 45).Select(async _ => await _orderService.ListAsync()));
        }
        catch (ShopifyRateLimitException)
        {
            caught = true;
        }

        Assert.False(caught);
    }

    [Fact]
    public async Task LeakyBucketGraphQlBreachShouldAttemptRetry()
    {
        _graphService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

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
            await Task.WhenAll(Enumerable.Range(0, 10).Select(async _ => await _graphService.PostAsync(query, queryCost)));
        }
        catch (ShopifyRateLimitException)
        {
            caught = true;
        }

        Assert.False(caught);
    }


    [Fact(Skip = "Temporarily disabled, see #755 on Github")]
    public async Task ForegroundRequestsMustRunBeforeBackgroundRequests()
    {
        var context = RequestContext.Background;
        // ReSharper disable once AccessToModifiedClosure
        var policy = new LeakyBucketExecutionPolicy(getRequestContext: () => context);
        var filter = new Filters.OrderListFilter
        {
            Status = "any",
            Limit = 1,
            Fields = "id"
        };

        DateTime? backgroundCompletedAt = null;
        DateTime? foregroundCompletedAt = null;

        async Task ListInBackground()
        {
            var tasks = Enumerable.Range(0, 50)
                .Select(_ => _orderService.ListAsync(filter));

            await Task.WhenAll(tasks);

            backgroundCompletedAt = DateTime.UtcNow;
        }

        async Task ListInForeground()
        {
            var tasks = Enumerable.Range(0, 10)
                .Select(_ => _orderService.ListAsync(filter));

            await Task.WhenAll(tasks);

            foregroundCompletedAt = DateTime.UtcNow;
        }

        _orderService.SetExecutionPolicy(policy);

        // Kick off background requests, which will trigger a throttle
        var bgTask = ListInBackground();

        // Change the context
        context = RequestContext.Foreground;

        // Now list in foreground, which should finish before the background tasks
        var fgTask = ListInForeground();

        await Task.WhenAll(bgTask, fgTask);

        Assert.NotNull(backgroundCompletedAt);
        Assert.NotNull(foregroundCompletedAt);

        testOutputHelper.WriteLine("Foreground completed at {0}", foregroundCompletedAt);
        testOutputHelper.WriteLine("Background completed at {0}", backgroundCompletedAt);

        Assert.True(foregroundCompletedAt < backgroundCompletedAt);
    }

    [Fact]
    public async Task UnparseableQueryShouldThrowError()
    {
        await Assert.ThrowsAnyAsync<Exception>(async () =>
        {
            _graphService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
            string query = "!#@$%$#%";
            await _graphService.PostAsync(query, 1);
        });
    }

    [Fact]
    public async Task UnknownFieldShouldThrowError()
    {
        await Assert.ThrowsAnyAsync<Exception>(async () =>
        {
            _graphService.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
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
            await _graphService.PostAsync(query, 1);
        });
    }
}
