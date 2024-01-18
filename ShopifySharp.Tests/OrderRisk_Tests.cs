using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;
using Xunit.Abstractions;

namespace ShopifySharp.Tests;

[Trait("Category", "OrderRisk")]
public class OrderRisk_Tests : IClassFixture<OrderRisk_Tests_Fixture>
{
    private OrderRisk_Tests_Fixture Fixture { get; }
    private readonly ITestOutputHelper _testOutputHelper;

    public OrderRisk_Tests(OrderRisk_Tests_Fixture fixture, ITestOutputHelper testOutputHelper)
    {
        this.Fixture = fixture;
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task Lists_Risks()
    {
        var list = await Fixture.Service.ListAsync(Fixture.OrderId);

        Assert.True(list.Items.Count() > 0);
    }

    [Fact]
    public async Task Deletes_Risks()
    {
        var created = await Fixture.Create(Fixture.OrderId, true);
        bool threw = false;

        try
        {
            await Fixture.Service.DeleteAsync(Fixture.OrderId, created.Id.Value);
        }
        catch (ShopifyException ex)
        {
            _testOutputHelper.WriteLine($"{nameof(Deletes_Risks)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }

    [Fact]
    public async Task Gets_Risks()
    {
        var created = await Fixture.Create(Fixture.OrderId);
        var risk = await Fixture.Service.GetAsync(created.OrderId.Value, created.Id.Value);

        Assert.NotNull(risk);
        Assert.Equal(Fixture.OrderId, risk.OrderId);
        Assert.Equal(Fixture.Message, risk.Message);
        Assert.Equal(Fixture.Score, risk.Score);
        Assert.Equal(Fixture.Recommendation, risk.Recommendation);
        Assert.Equal(Fixture.Source, risk.Source);
        Assert.Equal(Fixture.CauseCancel, risk.CauseCancel);
        Assert.Equal(Fixture.Display, risk.Display);
    }

    [Fact]
    public async Task Creates_Risks()
    {
        var created = await Fixture.Create(Fixture.OrderId);

        Assert.NotNull(created);
        Assert.Equal(Fixture.OrderId, created.OrderId);
        Assert.Equal(Fixture.Message, created.Message);
        Assert.Equal(Fixture.Score, created.Score);
        Assert.Equal(Fixture.Recommendation, created.Recommendation);
        Assert.Equal(Fixture.Source, created.Source);
        Assert.Equal(Fixture.CauseCancel, created.CauseCancel);
        Assert.Equal(Fixture.Display, created.Display);
    }

    [Fact]
    public async Task Updates_Risks()
    {
        string message = "An updated risk message.";
        var created = await Fixture.Create(Fixture.OrderId);
        long id = created.Id.Value;

        created.Message = message;
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(Fixture.OrderId, id, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal(message, updated.Message);
    }
}

public class OrderRisk_Tests_Fixture : IAsyncLifetime
{
    public OrderRiskService Service { get; } = new OrderRiskService(Utils.MyShopifyUrl, Utils.AccessToken);

    public OrderService OrderService { get; } = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<OrderRisk> Created { get; } = new List<OrderRisk>();

    public string Message => "This looks risky!";

    public decimal Score => (decimal)0.85;

    public string Recommendation => "cancel";

    public string Source => "External";

    public bool CauseCancel => false;

    public bool Display => true;

    public long OrderId { get; set; }

    public async Task InitializeAsync()
    {
        var policy = new LeakyBucketExecutionPolicy(false);

        Service.SetExecutionPolicy(policy);
        OrderService.SetExecutionPolicy(policy);

        OrderId = (await OrderService.ListAsync(new OrderListFilter()
        {
            Limit = 1
        })).Items.First().Id.Value;

        // Create a risk for count, list, get, etc. tests.
        await Create(OrderId);
    }

    public async Task DisposeAsync()
    {
        foreach (var obj in Created)
        {
            try
            {
                await Service.DeleteAsync(OrderId, obj.Id.Value);
            }
            catch (ShopifyException ex)
            {
                if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Failed to delete created OrderRisk with id {obj.Id.Value}. {ex.Message}");
                }
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
        {
            Created.Add(obj);
        }

        return obj;
    }
}