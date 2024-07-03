using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ShopifySharp.Tests;

[Trait("Category", "Country")]
public class Country_Tests : IClassFixture<Country_Tests_Fixture>
{
    private Country_Tests_Fixture Fixture { get; }
    private readonly ITestOutputHelper _testOutputHelper;

    public Country_Tests(Country_Tests_Fixture fixture, ITestOutputHelper testOutputHelper)
    {
        this.Fixture = fixture;
        _testOutputHelper = testOutputHelper;
    }

    [Fact(Skip = "The country API often throws errors stating that a country already exists, but that country is never returned when attempting to list/get/delete it.")]
    public async Task Counts_Countries()
    {
        var count = await Fixture.Service.CountAsync();

        Assert.True(count > 0);
    }

    [Fact(Skip = "The country API often throws errors stating that a country already exists, but that country is never returned when attempting to list/get/delete it.")]
    public async Task Deletes_Countries()
    {
        var countryCode = "CA";
        var created = await Fixture.Create(countryCode, true);
        bool threw = false;

        try
        {
            await Fixture.Service.DeleteAsync(created.Id.Value);
        }
        catch (ShopifyException ex)
        {
            _testOutputHelper.WriteLine($"{nameof(Deletes_Countries)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }

    [Fact(Skip = "The country API often throws errors stating that a country already exists, but that country is never returned when attempting to list/get/delete it.")]
    public async Task Gets_Countries()
    {
        var obj = await Fixture.Service.GetAsync(Fixture.Created.First().Id.Value);

        Assert.NotNull(obj);
        Assert.True(obj.Id.HasValue);
        Assert.NotEmpty(obj.Name);
        Assert.NotEmpty(obj.Name);
        Assert.Equal(Fixture.Tax, obj.Tax);
    }

    [Fact(Skip = "The country API often throws errors stating that a country already exists, but that country is never returned when attempting to list/get/delete it.")]
    public async Task Creates_Countries()
    {
        var countryCode = "AU";
        var obj = await Fixture.Create(countryCode);

        Assert.NotNull(obj);
        Assert.True(obj.Id.HasValue);
        Assert.Equal("AU", obj.Code);
        Assert.Equal("Australia", obj.Name);
        Assert.Equal(Fixture.Tax, obj.Tax);
    }

    [Fact(Skip = "The country API often throws errors stating that a country already exists, but that country is never returned when attempting to list/get/delete it.")]
    public async Task Updates_Countries()
    {
        var countryCode = "MX";
        var created = await Fixture.Create(countryCode);
        var newTax = 0.2M;
        var id = created.Id.Value;

        created.Tax = newTax;
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(id, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal(newTax, updated.Tax);
    }

    [Fact(Skip = "The Shopify API will randomly get 'stuck' and not return any countries when listing. It will return only empty arrays.")]
    public async Task Lists_Countries()
    {
        var createdCountry = await Fixture.Create("PT");
        var list = await Fixture.Service.ListAsync();
            
        Assert.True(list.Items.Any());
    }
}

public class Country_Tests_Fixture : IAsyncLifetime
{
    public CountryService Service { get; } = new CountryService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<Country> Created { get; } = new List<Country>();

    public decimal Tax = (decimal)0.14;

    public string TaxName = "VAT";

    public async Task InitializeAsync()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
            
        // Create one for count, list, get, etc. 
        await Create("IT");
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
                    Console.WriteLine($"Failed to delete created Country with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<Country> Create(string countryCode, bool skipAddToCreateList = false)
    {
        var obj = await Service.CreateAsync(new Country()
        {
            Code = countryCode,
            Tax = Tax
        });

        if (!skipAddToCreateList)
        {
            Created.Add(obj);
        }

        return obj;
    }
}
