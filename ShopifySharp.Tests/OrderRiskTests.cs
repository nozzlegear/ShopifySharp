using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "OrderRisk")]
public class OrderRiskTests(OrderRiskTestsFixture fixture) : IClassFixture<OrderRiskTestsFixture>
{
    [Fact]
    public async Task Lists_Risks()
    {
        // Setup
        var orderId = await fixture.GetOrderIdAsync();
        await fixture.Create(orderId);

        // Act
        var list = await fixture.Service.ListAsync(orderId);

        // Assert
        list.Items.Should().NotBeEmpty();
    }

    [Fact]
    public async Task Deletes_Risks()
    {
        // Setup
        var orderId = await fixture.GetOrderIdAsync();
        var created = await fixture.Create(orderId, true);

        // Act
        var act = async () => await fixture.Service.DeleteAsync(orderId, created.Id!.Value);

        // Assert
        await act.Should().NotThrowAsync("the service should delete order risk with id {0}", created.Id);
    }

    [Fact]
    public async Task Gets_Risks()
    {
        // Setup
        var orderId = await fixture.GetOrderIdAsync();
        var created = await fixture.Create(orderId);

        // Act
        var risk = await fixture.Service.GetAsync(orderId, created.Id!.Value);

        // Assert
        risk.Should().NotBeNull();
        risk.OrderId.Should().Be(orderId);
        risk.Message.Should().Be(fixture.Message);
        risk.Score.Should().Be(fixture.Score);
        risk.Recommendation.Should().Be(fixture.Recommendation);
        risk.Source.Should().Be(fixture.Source);
        risk.CauseCancel.Should().Be(fixture.CauseCancel);
        risk.Display.Should().Be(fixture.Display);
    }

    [Fact]
    public async Task Creates_Risks()
    {
        // Act
        var orderId = await fixture.GetOrderIdAsync();
        var created = await fixture.Create(orderId);

        // Assert
        created.Should().NotBeNull();
        created.OrderId.Should().Be(orderId);
        created.Message.Should().Be(fixture.Message);
        created.Score.Should().Be(fixture.Score);
        created.Recommendation.Should().Be(fixture.Recommendation);
        created.Source.Should().Be(fixture.Source);
        created.CauseCancel.Should().Be(fixture.CauseCancel);
        created.Display.Should().Be(fixture.Display);
    }

    [Fact]
    public async Task Updates_Risks()
    {
        // Setup
        const string message = "An updated risk message.";
        var orderId = await fixture.GetOrderIdAsync();
        var created = await fixture.Create(orderId);
        var createdId = created.Id!.Value;

        created.Message = message;
        created.Id = null;

        // Act
        var updated = await fixture.Service.UpdateAsync(orderId, createdId, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = createdId;

        // Assert
        updated.Message.Should().Be(message);
    }
}

public class OrderRiskTestsFixture : IAsyncLifetime
{
#pragma warning disable CS0618 // Type or member is obsolete
    public OrderRiskService Service { get; } = new (Utils.MyShopifyUrl, Utils.AccessToken);
#pragma warning restore CS0618 // Type or member is obsolete

    private OrderService OrderService { get; } = new (Utils.MyShopifyUrl, Utils.AccessToken);

    private List<OrderRisk> Created { get; } = [];

    public string Message => "This looks risky!";

    public decimal Score => (decimal)0.85;

    public string Recommendation => "cancel";

    public string Source => "External";

    public bool CauseCancel => false;

    public bool Display => true;

    private readonly ConcurrentBag<long> _orderIds = [];

    public Task InitializeAsync()
    {
        var policy = new LeakyBucketExecutionPolicy(false);

        Service.SetExecutionPolicy(policy);
        OrderService.SetExecutionPolicy(policy);

        return Task.CompletedTask;
    }

    public async Task DisposeAsync()
    {
        foreach (var obj in Created)
        {
            try
            {
                await Service.DeleteAsync(obj.OrderId!.Value, obj.Id!.Value);
            }
            catch (ShopifyHttpException ex) when (ex.HttpStatusCode != HttpStatusCode.NotFound)
            {
                Console.WriteLine($"Failed to delete created OrderRisk with id {obj.Id!.Value}. {ex.Message}");
            }
            catch (ShopifyHttpException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                // Ignore
            }
        }
    }

    public async Task<long> GetOrderIdAsync()
    {
        if (_orderIds.TryPeek(out var orderId))
            return orderId;

        var orderList = await OrderService.ListAsync(new OrderListFilter()
        {
            Limit = 1
        });
        var order = orderList.Items.FirstOrDefault();

        if (order is null)
            throw new NullReferenceException("Could not list orders for OrderRisk test setup.");

        _orderIds.Add(order.Id!.Value);
        return order.Id.Value;
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<OrderRisk> Create(long orderId, bool skipAddToCreatedList = false)
    {
        var obj = await Service.CreateAsync(orderId, new OrderRisk()
        {
            Message = Message,
            Score = Score,
            Recommendation = Recommendation,
            Source = Source,
            CauseCancel = CauseCancel,
            Display = Display,
        });

        if (!skipAddToCreatedList)
            Created.Add(obj);

        return obj;
    }
}
