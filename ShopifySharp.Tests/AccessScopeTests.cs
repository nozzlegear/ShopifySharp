using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "Access scope")]
public class AccessScopeTests : IClassFixture<AccessScopeTestsFixture>
{
    private AccessScopeTestsFixture Fixture { get; }

    public AccessScopeTests(AccessScopeTestsFixture fixture)
    {
        this.Fixture = fixture;
    }

    [Fact]
    public async Task List()
    {
        var scopes = await Fixture.Service.ListAsync();
        Assert.True(scopes.Count() > 0);
    }
}

public class AccessScopeTestsFixture : IAsyncLifetime
{
    public AccessScopeService Service { get; } = new AccessScopeService(Utils.MyShopifyUrl, Utils.AccessToken);

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