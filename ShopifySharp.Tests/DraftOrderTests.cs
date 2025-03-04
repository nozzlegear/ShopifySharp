using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ShopifySharp.Tests;

[Trait("Category", "DraftOrder")]
public class DraftOrderTests : IClassFixture<DraftOrderTestsFixture>
{
    private DraftOrderTestsFixture Fixture { get; }
    private readonly ITestOutputHelper _testOutputHelper;

    public DraftOrderTests(DraftOrderTestsFixture fixture, ITestOutputHelper testOutputHelper)
    {
        this.Fixture = fixture;
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task Counts_DraftOrders()
    {
        var count = await Fixture.Service.CountAsync();

        Assert.True(count > 0);
    }

    [Fact]
    public async Task Lists_DraftOrders()
    {
        var list = await Fixture.Service.ListAsync();

        Assert.True(list.Items.Count() > 0);
    }

    [Fact]
    public async Task Deletes_DraftOrders()
    {
        var created = await Fixture.Create(true);
        bool threw = false;

        try
        {
            await Fixture.Service.DeleteAsync(created.Id.Value);
        }
        catch (ShopifyException ex)
        {
            _testOutputHelper.WriteLine($"{nameof(Deletes_DraftOrders)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }

    [Fact]
    public async Task Gets_DraftOrders()
    {
        var created = await Fixture.Create();
        created = await Fixture.Service.GetAsync(created.Id.Value);

        Assert.NotNull(created);
        Assert.True(created.Id.HasValue);
        Assert.Equal(created.Note, Fixture.Note);
        Assert.False(string.IsNullOrEmpty(created.InvoiceUrl), "InvoiceUrl should not be null or empty.");

        foreach (var item in created.LineItems)
        {
            Assert.Equal(Fixture.LineItemTitle, item.Title);
            Assert.Equal(Fixture.LineItemQuantity, item.Quantity);
            Assert.Equal(Fixture.LineItemQuantity, item.Quantity);
        }
    }

    [Fact]
    public async Task Creates_DraftOrders()
    {
        var created = await Fixture.Create();

        Assert.NotNull(created);
        Assert.True(created.Id.HasValue);
        Assert.Equal(created.Note, Fixture.Note);
        Assert.False(string.IsNullOrEmpty(created.InvoiceUrl), "InvoiceUrl should not be null or empty.");

        foreach (var item in created.LineItems)
        {
            Assert.Equal(Fixture.LineItemTitle, item.Title);
            Assert.Equal(Fixture.LineItemQuantity, item.Quantity);
            Assert.Equal(Fixture.LineItemQuantity, item.Quantity);
        }
    }

    [Fact]
    public async Task Updates_DraftOrders()
    {
        string newNote = $"New note value {Guid.NewGuid()}";
        var created = await Fixture.Create();
        long id = created.Id.Value;

        created.Note = newNote;
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(id, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal(newNote, updated.Note);
    }

    [Fact(Skip = "Checkouts are disabled for ShopifySharp's dev store")]
    public async Task Sends_Invoice()
    {
        var created = await Fixture.Create();
        string to = "joshua@example.com";
        string subject = "Your draft order is ready";
        string message = "Pay pls";
        var result = await Fixture.Service.SendInvoiceAsync(created.Id.Value, new DraftOrderInvoice()
        {
            To = to,
            Subject = subject,
            CustomMessage = message,
        });

        Assert.False(String.IsNullOrEmpty(result.From), "`From` should not be null or empty");
        Assert.Equal(to, result.To);
        Assert.Equal(subject, result.Subject);
        Assert.Equal(message, result.CustomMessage);
    }

    [Fact(Skip = "Checkouts are disabled for ShopifySharp's dev store")]
    public async Task Completes_DraftOrder()
    {
        var created = await Fixture.Create();
        created = await Fixture.Service.CompleteAsync(created.Id.Value);

        Assert.NotNull(created.CompletedAt);
        Assert.Equal("completed", created.Status);
    }

    [Fact(Skip = "Checkouts are disabled for ShopifySharp's dev store")]
    public async Task Completes_DraftOrder_With_Pending_Payment()
    {
        var created = await Fixture.Create();
        created = await Fixture.Service.CompleteAsync(created.Id.Value, true);

        Assert.NotNull(created.CompletedAt);
        Assert.Equal("completed", created.Status);
    }
}

public class DraftOrderTestsFixture : IAsyncLifetime
{
    public DraftOrderService Service { get; } = new DraftOrderService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<DraftOrder> Created { get; } = new List<DraftOrder>();

    public string LineItemTitle = "Custom Draft Line Item";

    public decimal LineItemPrice = 15.00m;

    public int LineItemQuantity = 2;

    public string Note = "A note for the draft order.";

    public async Task InitializeAsync()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

        // Create one for count, list, get, etc. tests.
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
                    Console.WriteLine($"Failed to delete created DraftOrder with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<DraftOrder> Create(bool skipAddToCreateList = false)
    {
        var obj = await Service.CreateAsync(new DraftOrder()
        {
            LineItems = new List<DraftLineItem>()
            {
                new DraftLineItem()
                {
                    Title = LineItemTitle,
                    Price = LineItemPrice,
                    Quantity = LineItemQuantity,
                }
            },
            Note = Note
        });

        if (!skipAddToCreateList)
        {
            Created.Add(obj);
        }

        return obj;
    }
}
