using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "Transaction")]
public class Transaction_Tests : IClassFixture<Transaction_Tests_Fixture>
{
    private Transaction_Tests_Fixture Fixture { get; }

    public Transaction_Tests(Transaction_Tests_Fixture fixture)
    {
        this.Fixture = fixture;
    }

    [Fact]
    public async Task Counts_Transactions()
    {
        var count = await Fixture.Service.CountAsync(Fixture.Created.First().OrderId.Value);

        Assert.True(count > 0);
    }

    [Fact]
    public async Task Lists_Transactions()
    {
        var list = await Fixture.Service.ListAsync(Fixture.Created.First().OrderId.Value);

        Assert.True(list.Count() > 0);
    }

    [Fact]
    public async Task Gets_Transactions()
    {
        var order = await Fixture.CreateOrder();
        var created = await Fixture.Create(order.Id.Value, currency: order.Currency);
        var obj = await Fixture.Service.GetAsync(created.OrderId.Value, created.Id.Value);

        Assert.NotNull(obj);
        Assert.True(obj.Id.HasValue);
        Assert.Null(obj.ErrorCode);
        Assert.Equal(Fixture.Amount, obj.Amount);
        Assert.Equal(order.Currency, obj.Currency);
        Assert.Equal(Fixture.Status, obj.Status);
    }

    [Fact]
    public async Task Creates_Transactions()
    {
        var order = await Fixture.CreateOrder();
        var obj = await Fixture.Create(order.Id.Value, currency: order.Currency);

        Assert.NotNull(obj);
        Assert.True(obj.Id.HasValue);
        Assert.Null(obj.ErrorCode);
        Assert.Equal(Fixture.Amount, obj.Amount);
        Assert.Equal(order.Currency, obj.Currency);
        Assert.Equal(Fixture.Status, obj.Status);
    }

    [Fact]
    public async Task Creates_Capture_Transactions()
    {
        string kind = "capture";
        var order = await Fixture.CreateOrder();
        var obj = await Fixture.Create(order.Id.Value, kind, currency: order.Currency);

        Assert.Equal("success", obj.Status);
        Assert.Equal(kind, obj.Kind);
        Assert.Null(obj.ErrorCode);
    }

    [Fact(Skip = "This test returns the error 'Order cannot be refunded'. Orders that were created via API, not using a Shopify transaction gateway, cannot be refunded. Therefore, refunds are untestable.")]
    public async Task Creates_Refund_Transactions()
    {
        string kind = "refund";
        var order = await Fixture.CreateOrder();
        var obj = await Fixture.Create(order.Id.Value, kind);

        Assert.Equal("success", obj.Status);
        Assert.Equal(kind, obj.Kind);
        Assert.Null(obj.ErrorCode);
    }

    [Fact(Skip = "Transactions that aren't on store-credit or cash gateways require a parent_id.")]
    public async Task Creates_A_Void_Transaction()
    {
        string kind = "void";
        var order = await Fixture.CreateOrder();
        var obj = await Fixture.Create(order.Id.Value, kind);

        Assert.Equal("success", obj.Status);
        Assert.Equal(kind, obj.Kind);
        Assert.Null(obj.ErrorCode);
    }
}

public class Transaction_Tests_Fixture : IAsyncLifetime
{
    public TransactionService Service { get; } = new TransactionService(Utils.MyShopifyUrl, Utils.AccessToken);

    public OrderService OrderService { get; } = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<Transaction> Created { get; } = new List<Transaction>();

    public List<Order> CreatedOrders { get; } = new List<Order>();

    public decimal Amount => 10.00m;

    public string Currency => "USD";

    public string Gateway => "bogus";

    public string Status => "success";

    public long OrderId { get; set; }

    public async Task InitializeAsync()
    {
        var policy = new LeakyBucketExecutionPolicy(false);

        Service.SetExecutionPolicy(policy);
        OrderService.SetExecutionPolicy(policy);

        // Create one collection for use with count, list, get, etc. tests.
        var order = await CreateOrder();
        await Create(order.Id.Value, currency: order.Currency);
    }

    public async Task DisposeAsync()
    {
        foreach (var obj in CreatedOrders)
        {
            try
            {
                await OrderService.DeleteAsync(obj.Id.Value);
            }
            catch (ShopifyHttpException ex)
            {
                if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Failed to delete created Order with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }
    }

    public async Task<Order> CreateOrder()
    {
        var obj = await OrderService.CreateAsync(new Order()
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
            LineItems = new List<LineItem>()
            {
                new LineItem()
                {
                    Name = "Test Line Item",
                    Title = "Test Line Item Title",
                    Quantity = 2,
                    Price = 50
                },
                new LineItem()
                {
                    Name = "Test Line Item 2",
                    Title = "Test Line Item Title 2",
                    Quantity = 2,
                    Price = 50
                }
            },
            FinancialStatus = "paid",
            Transactions = new List<Transaction>()
            {
                new Transaction()
                {
                    Amount = 20.00m,
                    Status = "success",
                    Kind = "authorization",
                    Test = true,
                }
            },
            Email = Guid.NewGuid().ToString() + "@example.com",
            Note = "Test note about the customer.",
            Test = true
        }, new OrderCreateOptions()
        {
            SendFulfillmentReceipt = false,
            SendReceipt = false
        });

        CreatedOrders.Add(obj);

        return obj;
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<Transaction> Create(long orderId, string kind = "capture", bool skipAddToCreatedList = false, string currency = "USD")
    {
        var obj = await Service.CreateAsync(orderId, new Transaction()
        {
            Amount = Amount,
            Currency = currency,
            Gateway = Gateway,
            Status = Status,
            Test = true,
            Kind = kind
        });

        if (!skipAddToCreatedList)
        {
            Created.Add(obj);
        }

        return obj;
    }
}
