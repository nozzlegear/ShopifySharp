using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests;

[Trait("Category", "MetaField")]
public class MetaFieldTests : IClassFixture<MetaFieldTestsFixture>
{
    private MetaFieldTestsFixture Fixture { get; }
    private readonly ITestOutputHelper _testOutputHelper;

    public MetaFieldTests(MetaFieldTestsFixture fixture, ITestOutputHelper testOutputHelper)
    {
        this.Fixture = fixture;
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task Counts_Metafields()
    {
        var count = await Fixture.Service.CountAsync();

        Assert.True(count > 0);
    }

    [Fact]
    public async Task Counts_Metafields_On_Resources()
    {
        var count = await Fixture.Service.CountAsync(Fixture.ResourceId, Fixture.ResourceType);

        Assert.True(count > 0);
    }

    [Fact]
    public async Task Counting_Metafields_On_Resources_Downcases_ResourceType()
    {
        var exn = await Record.ExceptionAsync(async () => await Fixture.Service.CountAsync(Fixture.ResourceId, Fixture.ResourceType.ToUpper()));

        Assert.Null(exn);
    }

    [Fact]
    public async Task Counts_Metafields_On_Resources_And_Parent()
    {
        var count = await Fixture.Service.CountAsync(Fixture.ChildResourceId, Fixture.ChildResourceType, Fixture.ResourceId, Fixture.ResourceType);

        Assert.True(count > 0);
    }

    [Fact]
    public async Task Counting_Metafields_On_Resources_And_Parent_Downcases_ResourceTypes()
    {
        var exn = await Record.ExceptionAsync(async () => await Fixture.Service.CountAsync(Fixture.ChildResourceId, Fixture.ChildResourceType.ToUpper(), Fixture.ResourceId, Fixture.ResourceType.ToUpper()));

        Assert.Null(exn);
    }

    [Fact]
    public async Task Lists_Metafields()
    {
        var list = await Fixture.Service.ListAsync();

        Assert.Contains(list.Items, i => i.Namespace == Fixture.Namespace && i.Description == Fixture.Description);
    }

    [Fact]
    public async Task Lists_Metafields_On_Resources()
    {
        var list = await Fixture.Service.ListAsync(Fixture.ResourceId, Fixture.ResourceType);

        Assert.Contains(list.Items, i => i.Namespace == Fixture.Namespace && i.Description == Fixture.Description);
    }

    [Fact]
    public async Task Listing_Metafields_On_Resources_Downcases_ResourceType()
    {
        var exn = await Record.ExceptionAsync(async () => await Fixture.Service.ListAsync(Fixture.ResourceId, Fixture.ResourceType.ToUpper()));

        Assert.Null(exn);
    }

    [Fact]
    public async Task Lists_Metafields_On_Resources_And_Parent()
    {
        var list = await Fixture.Service.ListAsync(Fixture.ChildResourceId, Fixture.ChildResourceType, Fixture.ResourceId, Fixture.ResourceType);

        Assert.Contains(list.Items, i => i.Namespace == Fixture.Namespace && i.Description == Fixture.Description);
    }

    [Fact]
    public async Task Listing_Metafields_On_Resources_And_Parent_Downcases_ResourceTypes()
    {
        var exn = await Record.ExceptionAsync(async () => await Fixture.Service.ListAsync(Fixture.ChildResourceId, Fixture.ChildResourceType.ToUpper(), Fixture.ResourceId, Fixture.ResourceType.ToUpper()));

        Assert.Null(exn);
    }

    [Fact]
    public async Task Deletes_Metafields()
    {
        var created = await Fixture.Create(true);
        var threw = false;

        try
        {
            await Fixture.Service.DeleteAsync(created.Id.Value);
        }
        catch (ShopifyException ex)
        {
            _testOutputHelper.WriteLine($"{nameof(Deletes_Metafields)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }

    [Fact]
    public async Task Creates_Metafields()
    {
        var created = await Fixture.Create();

        Assert.NotNull(created);
        Assert.Equal(Fixture.Namespace, created.Namespace);
        Assert.Equal(Fixture.Description, created.Description);
        EmptyAssert.NotNullOrEmpty(created.Key);
        Assert.NotNull(created.Value);
    }

    [Fact]
    public async Task Creates_Metafields_On_Resources()
    {
        var created = await Fixture.Create(Fixture.ResourceId, Fixture.ResourceType);

        Assert.NotNull(created);
        Assert.Equal(Fixture.Namespace, created.Namespace);
        Assert.Equal(Fixture.Description, created.Description);
        EmptyAssert.NotNullOrEmpty(created.Key);
        Assert.NotNull(created.Value);
        Assert.Contains(created.OwnerResource, new [] { Fixture.ResourceType, Fixture.ResourceType.Substring(0, Fixture.ResourceType.Length - 1) });
        Assert.Equal(Fixture.ResourceId, created.OwnerId);
    }

    [Fact]
    public async Task Creating_Metafields_On_Resources_Downcases_ResourceType()
    {
        var exn = await Record.ExceptionAsync(async () => await Fixture.Create(Fixture.ResourceId, Fixture.ResourceType.ToUpper()));

        Assert.Null(exn);
    }

    [Fact]
    public async Task Creates_Metafields_On_Resources_And_Parent()
    {
        var created = await Fixture.Create(Fixture.ChildResourceId, Fixture.ChildResourceType, Fixture.ResourceId, Fixture.ResourceType);

        Assert.NotNull(created);
        Assert.Equal(Fixture.Namespace, created.Namespace);
        Assert.Equal(Fixture.Description, created.Description);
        EmptyAssert.NotNullOrEmpty(created.Key);
        Assert.NotNull(created.Value);
        Assert.Contains(created.OwnerResource, new [] { Fixture.ChildResourceType, Fixture.ChildResourceType.Substring(0, Fixture.ChildResourceType.Length - 1) });
        Assert.Equal(Fixture.ChildResourceId, created.OwnerId);
    }

    [Fact]
    public async Task Creating_Metafields_On_Resources_And_Parent_Downcases_ResourceTypes()
    {
        var exn = await Record.ExceptionAsync(async () => await Fixture.Create(Fixture.ChildResourceId, Fixture.ChildResourceType.ToUpper(), Fixture.ResourceId, Fixture.ResourceType.ToUpper()));

        Assert.Null(exn);
    }

    [Fact]
    public async Task Updates_Metafields()
    {
        var value = "10";
        var created = await Fixture.Create();
        var id = created.Id.Value;

        created.Value = value;
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(id, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal(value, updated.Value.ToString());
    }

    [Fact]
    public async Task Updates_Metafields_On_Resources()
    {
        var value = "10";
        var created = await Fixture.Create(Fixture.ResourceId, Fixture.ResourceType);
        var id = created.Id.Value;

        created.Value = value;
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(id, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal(value, updated.Value.ToString());
    }

    [Fact]
    public async Task Updates_Metafields_On_Child_Resources()
    {
        var value = "10";
        var created = await Fixture.Create(Fixture.ChildResourceId, Fixture.ChildResourceType);
        var id = created.Id.Value;

        created.Value = value;
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(id, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal(value, updated.Value.ToString());
    }

    [Fact]
    public async Task Updates_Metafields_On_Resources_And_Parent()
    {
        var value = "10";
        var created = await Fixture.Create(Fixture.ChildResourceId, Fixture.ChildResourceType, Fixture.ResourceId, Fixture.ResourceType);
        var id = created.Id.Value;

        created.Value = value;
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(id, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal(value, updated.Value.ToString());
    }
}

public class MetaFieldTestsFixture : IAsyncLifetime
{
    public MetaFieldService Service { get; } = new MetaFieldService(Utils.MyShopifyUrl, Utils.AccessToken);

    public ProductService ProductService { get; } = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<MetaField> Created { get; } = new List<MetaField>();

    public string Namespace => "testing";
    public string Description => "This is a test meta field. It is an integer value.";
    public string ResourceType => "products";
    public string ChildResourceType => "variants";
    public long ResourceId { get; set; }
    public long ChildResourceId { get; set; }

    public async Task InitializeAsync()
    {
        var policy = new LeakyBucketExecutionPolicy();

        Service.SetExecutionPolicy(policy);
        ProductService.SetExecutionPolicy(policy);

        // Get a product to add metafields to.
        var products = await ProductService.ListAsync();
        ResourceId = products.Items.First().Id.Value;
        ChildResourceId = products.Items.First().Variants.First().Id.Value;

        // Create a metafield for use in count, list, get, etc. tests.
        await Create();
        await Create(ResourceId, ResourceType);
        await Create(ChildResourceId, ChildResourceType, ResourceId, ResourceType);
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
                    Console.WriteLine($"Failed to delete created MetaField with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<MetaField> Create(bool skipAddToCreatedList = false)
    {
        var obj = await Service.CreateAsync(new MetaField()
        {
            Namespace = Namespace,
            Key = Guid.NewGuid().ToString().Substring(0, 25),
            Value = "5",
            Type = "integer",
            Description = Description,
        });

        if (!skipAddToCreatedList)
        {
            Created.Add(obj);
        }

        return obj;
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<MetaField> Create(long targetId, string resourceType, bool skipAddToCreatedList = false)
    {
        var obj = await Service.CreateAsync(new MetaField()
        {
            Namespace = Namespace,
            Key = Guid.NewGuid().ToString().Substring(0, 25),
            Value = "5",
            Type = "integer",
            Description = Description,
        }, targetId, resourceType);

        if (!skipAddToCreatedList)
        {
            Created.Add(obj);
        }

        return obj;
    }

    /// <summary>
    /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
    /// </summary>
    public async Task<MetaField> Create(long targetId, string resourceType, long parentTargetId, string parentResourceType, bool skipAddToCreatedList = false)
    {
        var obj = await Service.CreateAsync(new MetaField()
        {
            Namespace = Namespace,
            Key = Guid.NewGuid().ToString().Substring(0, 25),
            Value = "5",
            Type = "integer",
            Description = Description,
        }, targetId, resourceType, parentTargetId, parentResourceType);

        if (!skipAddToCreatedList)
        {
            Created.Add(obj);
        }

        return obj;
    }
}
