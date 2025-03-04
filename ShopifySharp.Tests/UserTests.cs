using System.Linq;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;
using System.Threading;

namespace ShopifySharp.Tests;

[Trait("Category", "User")]
public class UserTests : IClassFixture<UserTestsFixture>
{
    private UserTestsFixture Fixture { get; }

    public UserTests(UserTestsFixture fixture)
    {
        this.Fixture = fixture;
    }


    [Fact(Skip = "Cannot run without a Shopify Plus account.")]
    public async Task Lists_Users()
    {
        var result = await Fixture.Service.ListAsync();
        var list = result.Items;

        Assert.True(list.Any());
    }


    [Fact(Skip = "Cannot run without a Shopify Plus account.")]
    public async Task Gets_Users()
    {
        // Find an id 
        var result = await Fixture.Service.ListAsync();
        var list = result.Items;
        var user = await Fixture.Service.GetAsync(list.First().Id.Value);

        Assert.NotNull(user);
        Assert.Equal(user.Id, list.First().Id);
    }

    [Fact(Skip = "Cannot run without a Shopify Plus account")]
    public async Task No_Ambiguous_List_Calls()
    {
        // This test simply ensures each of the three ListAsync methods can be called without an ambiguous call error
        var userFilter = new UserListFilter();
        var listFilter = userFilter.AsListFilter();
        var cancellationToken = new CancellationTokenSource().Token;
            
        var result = await Fixture.Service.ListAsync();
        result = await Fixture.Service.ListAsync(cancellationToken: cancellationToken);
        result = await Fixture.Service.ListAsync(userFilter);
        result = await Fixture.Service.ListAsync(userFilter, cancellationToken);
        result = await Fixture.Service.ListAsync(listFilter);
        result = await Fixture.Service.ListAsync(listFilter, cancellationToken);
    }
}

public class UserTestsFixture : IAsyncLifetime
{
    public UserService Service => new UserService(Utils.MyShopifyUrl, Utils.AccessToken);

    public Task InitializeAsync()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

        return Task.CompletedTask;
    }

    public Task DisposeAsync() => Task.CompletedTask;
}