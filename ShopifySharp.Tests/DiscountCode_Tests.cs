using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "DiscountCodes")]
public class DiscountCode_Tests : IClassFixture<DiscountCodes_Tests_Fixture>
{
    private DiscountCodes_Tests_Fixture Fixture { get; }

    public DiscountCode_Tests(DiscountCodes_Tests_Fixture fixture)
    {
        this.Fixture = fixture;
    }

    private string UniqueCode(string prefix) =>
        prefix + Guid.NewGuid().ToString().Substring(0, 6);

    [Fact]
    public async Task Creates_DiscountCode()
    {
        var code = UniqueCode("UNIT_TEST_CREATE");
        var created = await Fixture.Create(code);

        Assert.NotNull(created);
        Assert.Equal(code, created.Code);
        Assert.NotNull(created.UsageCount);
    }

    [Fact]
    public async Task Lists_DiscountCodes()
    {
        var code = UniqueCode("UNIT_TEST_LIST");
        var created = await Fixture.Create(code);
        var priceRuleId = created.PriceRuleId.Value;
        var list = await Fixture.DiscountCodeService.ListAsync(priceRuleId, new PriceRuleDiscountCodeListFilter
        {
            Limit = 5
        });

        Assert.NotEmpty(list.Items);
    }

    [Fact]
    public async Task Gets_DiscountCode()
    {
        var code = UniqueCode("UNIT_TEST_GET");
        var created = await Fixture.Create(code);
        var discount = await Fixture.DiscountCodeService.GetAsync(created.PriceRuleId.Value, created.Id.Value);

        Assert.NotNull(discount);
        Assert.Equal(code, discount.Code);
    }

    [Fact]
    public async Task Gets_DiscountCode_By_Code()
    {
        var code = UniqueCode("UNIT_TEST_GET_BY_CODE");
        var created = await Fixture.Create(code);
        var retrieved = await Fixture.DiscountCodeService.GetAsync(code);

        Assert.NotNull(retrieved);
        Assert.Equal(code, retrieved.Code);
        Assert.Equal(created.Id.Value, retrieved.Id.Value);
    }

    [Fact]
    public async Task Updates_DiscountCode()
    {
        var oldCode = UniqueCode("UNIT_TEST_UPDATE_BEFORE");
        var newCode = UniqueCode("UNIT_TEST_UPDATE_AFTER");
        var created = await Fixture.Create(oldCode);
        created.Code = newCode;

        var updated = await Fixture.DiscountCodeService.UpdateAsync(created.PriceRuleId.Value, created);

        Assert.NotNull(updated);
        Assert.Equal(newCode, updated.Code);
    }
}

public class DiscountCodes_Tests_Fixture : IAsyncLifetime
{
    public DiscountCodeService DiscountCodeService { get; } = new DiscountCodeService(Utils.MyShopifyUrl, Utils.AccessToken);

    public PriceRuleService PriceRuleService { get; } = new PriceRuleService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<PriceRuleDiscountCode> CreatedDiscountCodes { get; } = new List<PriceRuleDiscountCode>();

    public List<PriceRule> CreatedPriceRules { get; } = new List<PriceRule>();

    public Task InitializeAsync()
    {
        var policy = new LeakyBucketExecutionPolicy();

        DiscountCodeService.SetExecutionPolicy(policy);
        PriceRuleService.SetExecutionPolicy(policy);
        return Task.CompletedTask;
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish. 
    /// A PriceRule is created then a PriceRuleDiscountCode is assigned to it
    /// </summary>
    public async Task<PriceRuleDiscountCode> Create(string code, bool skipAddToCreatedList = false)
    {
        var ruleObj = await CreatePriceRule(skipAddToCreatedList);

        var discountCode = new PriceRuleDiscountCode()
        {
            Code = code,
            PriceRuleId = ruleObj.Id.Value,
        };

        return await CreateDiscountCode(ruleObj, discountCode, skipAddToCreatedList);
    }

    private async Task<PriceRule> CreatePriceRule(bool skipAddToCreatedList)
    {
        var priceRule = new PriceRule()
        {
            Title = "UNIT TEST",
            ValueType = "percentage",
            Value = -30,
            TargetType = "line_item",
            TargetSelection = "all",
            AllocationMethod = "across",
            StartsAt = DateTime.Now,
            CustomerSelection = "all"
        };

        return await CreatePriceRule(priceRule, skipAddToCreatedList);
    }

    private async Task<PriceRule> CreatePriceRule(PriceRule rule, bool skipAddToCreatedList)
    {
        var obj = await PriceRuleService.CreateAsync(rule);

        if (!skipAddToCreatedList)
        {
            CreatedPriceRules.Add(obj);
        }

        return obj;
    }

    private async Task<PriceRuleDiscountCode> CreateDiscountCode(PriceRule rule, PriceRuleDiscountCode discountCode, bool skipAddToCreatedList)
    {
        var obj = await DiscountCodeService.CreateAsync(rule.Id.Value, discountCode);

        if (!skipAddToCreatedList)
        {
            CreatedDiscountCodes.Add(obj);
        }

        return obj;
    }

    public async Task DisposeAsync()
    {
        await DeleteDiscountCodes();
        await DeletePriceRules();
    }

    private async Task DeleteDiscountCodes()
    {
        foreach (var obj in CreatedDiscountCodes)
        {
            try
            {
                await DiscountCodeService.DeleteAsync(obj.PriceRuleId.Value, obj.Id.Value);
            }
            catch (ShopifyHttpException ex)
            {
                if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Failed to delete created PriceRuleDiscountCode with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }
    }

    private async Task DeletePriceRules()
    {
        foreach (var obj in CreatedPriceRules)
        {
            try
            {
                await PriceRuleService.DeleteAsync(obj.Id.Value);
            }
            catch (ShopifyHttpException ex)
            {
                if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Failed to delete created PriceRule with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }
    }
}
