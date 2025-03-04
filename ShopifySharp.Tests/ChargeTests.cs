using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "Charge")]
public class ChargeTests : IClassFixture<ChargeTestsFixture>
{
    private readonly ChargeTestsFixture Fixture;

    public ChargeTests(ChargeTestsFixture fixture)
    {
        Fixture = fixture;
    }

    [Fact(Skip = "Charges cannot be tested with a private application.")]
    public void Creates_Charges()
    {
        // Can't be tested.
    }

    [Fact(Skip = "Charges cannot be tested with a private application.")]
    public void Activates_Charges()
    {
        // Can't be tested.
    }

    [Fact(Skip = "Charges cannot be tested with a private application.")]
    public void Lists_Charges()
    {
        // Can't be tested.
    }

    [Fact(Skip = "Charges cannot be tested with a private application.")]
    public void Gets_Charges()
    {
        // Can't be tested.
    }
}

public class ChargeTestsFixture : IAsyncLifetime
{
    public readonly ChargeService Service = new ChargeService(Utils.MyShopifyUrl, Utils.AccessToken);

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