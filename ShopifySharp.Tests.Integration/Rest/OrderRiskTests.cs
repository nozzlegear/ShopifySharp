using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace ShopifySharp.Tests.Integration.Rest;

[Trait("Category", "OrderRisk")]
public class OrderRiskTests(OrderRiskTestsFixture fixture) : IClassFixture<OrderRiskTestsFixture>
{
    [Fact]
    public async Task Lists_Risks()
    {
        // Setup
        var orderId = fixture.OrderId;
        await fixture.Create(orderId);

        // Act
        var list = await fixture.Service.ListAsync(orderId, cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        list.Items.Should().NotBeEmpty();
    }

    [Fact]
    public async Task Deletes_Risks()
    {
        // Setup
        var orderId = fixture.OrderId;
        var created = await fixture.Create(orderId, true);

        // Act
        var act = async () => await fixture.Service.DeleteAsync(orderId, created.Id!.Value, cancellationToken: TestContext.Current.CancellationToken);

        // Assert
        await act.Should().NotThrowAsync("the service should delete order risk with id {0}", created.Id);
    }

    [Fact]
    public async Task Gets_Risks()
    {
        // Setup
        var orderId = fixture.OrderId;
        var created = await fixture.Create(orderId);

        // Act
        var risk = await fixture.Service.GetAsync(orderId, created.Id!.Value, cancellationToken: TestContext.Current.CancellationToken);

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
        var orderId = fixture.OrderId;
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
        var orderId = fixture.OrderId;
        var created = await fixture.Create(orderId);
        var createdId = created.Id!.Value;

        created.Message = message;
        created.Id = null;

        // Act
        var updated = await fixture.Service.UpdateAsync(orderId, createdId, created, cancellationToken: TestContext.Current.CancellationToken);

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

    public OrderService OrderService { get; } = new (Utils.MyShopifyUrl, Utils.AccessToken);

    private List<OrderRisk> Created { get; } = [];

    public long OrderId { get; private set; }

    private readonly List<Order> _createdOrders = [];

    public string Message => "This looks risky!";

    public decimal Score => (decimal)0.85;

    public string Recommendation => "cancel";

    public string Source => "External";

    public bool CauseCancel => false;

    public bool Display => true;

    public async System.Threading.Tasks.ValueTask InitializeAsync()
    {
        var policy = new LeakyBucketExecutionPolicy(false);

        Service.SetExecutionPolicy(policy);
        OrderService.SetExecutionPolicy(policy);

        // Create a unique order for the OrderRisk tests so we don't depend on existing orders.
        var order = await OrderService.CreateAsync(new Order()
        {
            CreatedAt = DateTime.UtcNow,
            BillingAddress = new Address()
            {
                Address1 = "123 4th Street",
                City = "Minneapolis",
                Province = "Minnesota",
                ProvinceCode = "MN",
                Zip = "55401",
                Phone = "555-555-5555",
                FirstName = "John",
                LastName = "Doe",
                Company = "Tomorrow Corporation",
                Country = "United States",
                CountryCode = "US",
                Default = true,
            },
            LineItems =
            [
                new LineItem()
                {
                    Name = "Test Line Item",
                    Title = "Test Line Item Title",
                    Quantity = 2,
                    Price = 5
                },
                new LineItem()
                {
                    Name = "Test Line Item 2",
                    Title = "Test Line Item Title 2",
                    Quantity = 2,
                    Price = 5
                }
            ],
            FinancialStatus = "paid",
            TotalPrice = 5.00m,
            Email = Guid.NewGuid().ToString() + "@example.com",
            Note = "This order was created while testing OrderRisk!",
            Test = true
        });

        _createdOrders.Add(order);
        OrderId = order.Id!.Value;
    }

    public async System.Threading.Tasks.ValueTask DisposeAsync()
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

        foreach (var order in _createdOrders)
        {
            try
            {
                await OrderService.DeleteAsync(order.Id!.Value);
            }
            catch (ShopifyHttpException ex) when (ex.HttpStatusCode != HttpStatusCode.NotFound)
            {
                Console.WriteLine($"Failed to delete created Order with id {order.Id!.Value}. {ex.Message}");
            }
            catch (ShopifyHttpException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                // Ignore
            }
        }
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
