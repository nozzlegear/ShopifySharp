using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;
using Xunit.Abstractions;

namespace ShopifySharp.Tests;

[Trait("Category", "Order")]
public class Order_Tests : IClassFixture<Order_Tests_Fixture>
{
    private Order_Tests_Fixture Fixture { get; }
    private readonly ITestOutputHelper _testOutputHelper;

    public Order_Tests(Order_Tests_Fixture fixture, ITestOutputHelper testOutputHelper)
    {
        this.Fixture = fixture;
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task Counts_Orders()
    {
        var count = await Fixture.Service.CountAsync();

        Assert.True(count > 0);
    }

    [Fact]
    public async Task Lists_Orders()
    {
        var list = await Fixture.Service.ListAsync();

        Assert.True(list.Items.Count() > 0);
    }

    [Fact]
    public async Task Lists_Orders_With_Filter()
    {
        var created = await Task.WhenAll(Enumerable.Range(0, 2).Select(i => Fixture.Create()));
        var ids = created.Select(o => o.Id.Value);
        var list = await Fixture.Service.ListAsync(new OrderListFilter()
        {
            Ids = ids
        });

        Assert.All(list.Items, o => Assert.Contains(o.Id.Value, ids));
    }

    [Fact]
    public async Task Deletes_Orders()
    {
        var created = await Fixture.Create(true);
        bool threw = false;

        try
        {
            await Fixture.Service.DeleteAsync(created.Id.Value);
        }
        catch (ShopifyException ex)
        {
            _testOutputHelper.WriteLine($"{nameof(Deletes_Orders)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }

    [Fact]
    public async Task Gets_Orders()
    {
        var order = await Fixture.Service.GetAsync(Fixture.Created.First().Id.Value);

        Assert.NotNull(order);
        Assert.Equal(Fixture.Note, order.Note);
        Assert.True(order.Id.HasValue);
    }

    [Fact]
    public async Task Creates_Orders()
    {
        var created = await Fixture.Create();

        Assert.NotNull(created);
        Assert.Equal(Fixture.Note, created.Note);
        Assert.True(created.Id.HasValue);
    }

    [Fact]
    public async Task Updates_Orders()
    {
        string note = "This note was updated while testing ShopifySharp!";
        var created = await Fixture.Create();
        long id = created.Id.Value;

        created.Note = note;
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(id, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal(note, updated.Note);
    }

    [Fact]
    public async Task Opens_Orders()
    {
        // Close an order before opening it.
        var closed = await Fixture.Service.CloseAsync(Fixture.Created.First().Id.Value);
        var opened = await Fixture.Service.OpenAsync(closed.Id.Value);

        Assert.False(opened.ClosedAt.HasValue);
    }

    [Fact]
    public async Task Closes_Orders()
    {
        var closed = await Fixture.Service.CloseAsync(Fixture.Created.Last().Id.Value);

        Assert.True(closed.ClosedAt.HasValue);
    }

    [Fact]
    public async Task Cancels_Orders()
    {
        var order = await Fixture.Create();
        bool threw = false;

        try
        {
            await Fixture.Service.CancelAsync(order.Id.Value);
        }
        catch (ShopifyException ex)
        {
            _testOutputHelper.WriteLine($"{nameof(Cancels_Orders)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }

    [Fact]
    public async Task Cancels_Orders_With_Options()
    {
        var order = await Fixture.Create();
        bool threw = false;

        try
        {
            await Fixture.Service.CancelAsync(order.Id.Value, new OrderCancelOptions()
            {
                Reason = "customer"
            });
        }
        catch (ShopifyException ex)
        {
            _testOutputHelper.WriteLine($"{nameof(Cancels_Orders_With_Options)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }

    [Fact]
    public async Task Gets_Metafields()
    {
        var order = await Fixture.Create();
        bool threw = false;

        try
        {
            await Fixture.Service.GetMetaFieldsAsync(order.Id.Value);
        }
        catch (ShopifyException ex)
        {
            _testOutputHelper.WriteLine($"{nameof(Gets_Metafields)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }

    [Fact]
    public async Task Can_Be_Partially_Updated()
    {
        string newNote = "These notes were part of a partial update to this order.";
        var created = await Fixture.Create();
        var updated = await Fixture.Service.UpdateAsync(created.Id.Value, new Order()
        {
            Note = newNote
        });

        Assert.Equal(created.Id, updated.Id);
        Assert.Equal(newNote, updated.Note);

        // In previous versions of ShopifySharp, the updated JSON would have sent 'email=null', clearing out the email address.
        Assert.Equal(created.Email, updated.Email);
    }

    [Fact]
    public void TipPaymentGatewaySpecified_GetDeserialized()
    {
        string orderJson = @"{
  ""id"": 123,
  ""line_items"": [
    {
      ""id"": 123,
      ""tip_payment_gateway"": null
    }
  ]
}
";
        var order = ShopifySharp.Infrastructure.Serializer.Deserialize<Order>(orderJson);
        Assert.Null(order.LineItems.First().TipPaymentGateway);
        Assert.True(order.LineItems.First().TipPaymentGatewaySpecified);
    }
}

public class Order_Tests_Fixture : IAsyncLifetime
{
    public OrderService Service { get; } = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);

    public string Note => "This order was created while testing ShopifySharp!";

    public List<Order> Created { get; } = new List<Order>();

    public async Task InitializeAsync()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy(false));

        // Create an order for count, list, get, etc. orders.
        await Create();
    }

    public async Task DisposeAsync()
    {
        foreach (var obj in Created)
        {
            try
            {
                await Service.DeleteAsync(obj.Id.Value);
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

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<Order> Create(bool skipAddToCreateList = false)
    {
        var obj = await Service.CreateAsync(new Order()
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
                    Price = 5
                },
                new LineItem()
                {
                    Name = "Test Line Item 2",
                    Title = "Test Line Item Title 2",
                    Quantity = 2,
                    Price = 5
                }
            },
            FinancialStatus = "paid",
            TotalPrice = 5.00m,
            Email = Guid.NewGuid().ToString() + "@example.com",
            Note = Note,
            Test = true
        });

        if (!skipAddToCreateList)
        {
            Created.Add(obj);
        }

        return obj;
    }
}
