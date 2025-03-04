using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ShopifySharp.Tests;

[Trait("Category", "PriceRule")]
public class PriceRuleTests : IClassFixture<PriceRuleTestsFixture>
{
    private PriceRuleTestsFixture Fixture { get; }
    private readonly ITestOutputHelper _testOutputHelper;

    public PriceRuleTests(PriceRuleTestsFixture fixture, ITestOutputHelper testOutputHelper)
    {
        this.Fixture = fixture;
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task Lists_PriceRules()
    {
        var list = await Fixture.Service.ListAsync();

        Assert.True(list.Items.Count() > 0);
    }

    [Fact]
    public async Task Deletes_PriceRules()
    {
        string suffix = Guid.NewGuid().ToString();
        var created = await Fixture.Create(suffix, true);
        bool threw = false;

        try
        {
            await Fixture.Service.DeleteAsync(created.Id.Value);
        }
        catch (ShopifyException ex)
        {
            _testOutputHelper.WriteLine($"{nameof(Deletes_PriceRules)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }

    [Fact]
    public async Task Gets_PriceRules()
    {
        string suffix = Guid.NewGuid().ToString();
        var created = await Fixture.Create(suffix);
        var rule = await Fixture.Service.GetAsync(created.Id.Value);

        Assert.NotNull(rule);
        Assert.Equal(Fixture.ValueType, rule.ValueType);
        Assert.Equal(Fixture.TargetType, rule.TargetType);
        Assert.Equal(Fixture.TargetSelection, rule.TargetSelection);
        Assert.Equal(Fixture.AllocationMethod, rule.AllocationMethod);
        Assert.Equal(Fixture.Value, rule.Value);
    }

    [Fact]
    public async Task Creates_PriceRules()
    {
        string suffix = Guid.NewGuid().ToString();
        var created = await Fixture.Create(suffix);

        Assert.NotNull(created);
        Assert.StartsWith(Fixture.TitlePrefix, created.Title);
        Assert.Equal(Fixture.ValueType, created.ValueType);
        Assert.Equal(Fixture.TargetType, created.TargetType);
        Assert.Equal(Fixture.TargetSelection, created.TargetSelection);
        Assert.Equal(Fixture.AllocationMethod, created.AllocationMethod);
        Assert.Equal(Fixture.Value, created.Value);
    }

    [Fact]
    public async Task Updates_PriceRules()
    {
        var suffix = Guid.NewGuid().ToString();
        var created = await Fixture.Create(suffix);
        var id = created.Id.Value;

        created.Value = -5.0m;
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(id, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal(created.Value, updated.Value);
    }
}

public class PriceRuleTestsFixture : IAsyncLifetime
{
    public PriceRuleService Service { get; } = new PriceRuleService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<PriceRule> Created { get; } = new List<PriceRule>();

    public string TitlePrefix => "ShopifySharp PriceRule ";

    public string ValueType => "percentage";

    public string TargetType => "line_item";

    public string TargetSelection => "all";

    public string AllocationMethod => "across";

    public decimal Value => -10.0m;

    public string CustomerSelection => "all";

    public bool OncePerCustomer => false;


    public async Task InitializeAsync()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

        // Create one for count, list, get, etc. orders.
        await Create(Guid.NewGuid().ToString());
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
                    Console.WriteLine($"Failed to delete created Page with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<PriceRule> Create(string titleGuid, bool skipAddToCreatedList = false)
    {
        var obj = await Service.CreateAsync(new ShopifySharp.PriceRule()
        {
            Title = this.TitlePrefix + titleGuid,
            ValueType = this.ValueType,
            TargetType = this.TargetType,
            TargetSelection = this.TargetSelection,
            AllocationMethod = this.AllocationMethod,
            Value = this.Value,
            CustomerSelection = this.CustomerSelection,
            OncePerCustomer = this.OncePerCustomer,
            PrerequisiteSubtotalRange = new PrerequisiteValueRange()
            {
                GreaterThanOrEqualTo = 40
            },
            StartsAt = new DateTimeOffset(DateTime.Now)
        });

        if (!skipAddToCreatedList)
        {
            Created.Add(obj);
        }

        return obj;
    }
}
