using System;
using System.Linq;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "TenderTransaction")]
public class TenderTransactionTests : IClassFixture<TenderTransactionTestsFixture>
{
    private TenderTransactionTestsFixture Fixture { get; }

    public TenderTransactionTests(TenderTransactionTestsFixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task Lists_TenderTransactions()
    {
        var list = await Fixture.Service.ListAsync();
            
        Assert.True(list.Items.Any());
    }

    [Fact]
    public async Task Lists_TenderTransactions_WithFilter()
    {
        var list = await Fixture.Service.ListAsync(new TenderTransactionListFilter
        {
            ProcessedAtMin = DateTime.Now.AddDays(30)
        });

        Assert.True(!list.Items.Any());
    }
}

public class TenderTransactionTestsFixture : IAsyncLifetime
{
    public TenderTransactionService Service { get; } = new TenderTransactionService(Utils.MyShopifyUrl, Utils.AccessToken);

    public Task InitializeAsync()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

        return Task.CompletedTask;
    }

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }
}