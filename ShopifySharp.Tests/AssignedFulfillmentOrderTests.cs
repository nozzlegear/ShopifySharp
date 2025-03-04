using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "AssignedFulfillmentOrder")]
public class AssignedFulfillmentOrderTests : IClassFixture<AssignedFulfillmentOrderTestsFixture>
{
    private AssignedFulfillmentOrderTestsFixture Fixture { get; }

    public AssignedFulfillmentOrderTests(AssignedFulfillmentOrderTestsFixture fixture)
    {
        this.Fixture = fixture;
    }

    [Fact]
    public async Task ListsCancellationRequests_AssignedFulfillmentOrders()
    {
        var result = await Fixture.Service.ListAsync(new AssignedFulfillmentOrderFilter(){AssignmentStatus = "cancellation_requested" });

        Assert.NotNull(result);
    }

    [Fact]
    public async Task ListsRequests_AssignedFulfillmentOrders()
    {
        var result = await Fixture.Service.ListAsync(new AssignedFulfillmentOrderFilter() { AssignmentStatus = "fulfillment_requested" });

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ListsAcceptedRequests_AssignedFulfillmentOrders()
        {
            var result = await Fixture.Service.ListAsync(new AssignedFulfillmentOrderFilter() { AssignmentStatus = "fulfillment_accepted" });

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ListsUnsubmittedFulfillmentOrders_AssignedFulfillmentOrders()
        {
            var result = await Fixture.Service.ListAsync(new AssignedFulfillmentOrderFilter() { AssignmentStatus = "fulfillment_unsubmitted", Limit = 1 });

            Assert.NotNull(result);
        }
    }

    public class AssignedFulfillmentOrderTestsFixture : IAsyncLifetime
    {
        public AssignedFulfillmentOrderService Service { get; } = new AssignedFulfillmentOrderService(Utils.MyShopifyUrl, Utils.AccessToken);

        public FulfillmentService FulfillmentService { get; } = new FulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);

    public OrderService OrderService { get; } = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<Fulfillment> CreatedFulfillments { get; } = new List<Fulfillment>();

    public Task InitializeAsync()
    {
        // Fulfillment API has a stricter rate limit when on a non-paid store.
        var policy = new LeakyBucketExecutionPolicy();

        Service.SetExecutionPolicy(policy);
        FulfillmentService.SetExecutionPolicy(policy);
        OrderService.SetExecutionPolicy(policy);

        // Create an order and fulfillment for count, list, get, etc. tests.
        //var order = await CreateOrder();
        //var fulfillment = await CreateFulfillment(order.Id.Value);
        return Task.CompletedTask;
    }

    public async Task DisposeAsync()
    {
        foreach (var obj in CreatedFulfillments)
        {
            try
            {
                await OrderService.DeleteAsync(obj.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"Failed to delete order with id {obj.Id.Value}. {ex.Message}");
            }
        }
    }
}
