using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "UsageCharge")]
public class UsageChargeTests
{
    UsageChargeService Service { get; } = new UsageChargeService(Utils.MyShopifyUrl, Utils.AccessToken);

    UsageChargeTests()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
    }

    [Fact(Skip = "Usage charges cannot be tested with a private application.")]
    public void Creates_Charges()
    {
        // Can't be tested.
    }

    [Fact(Skip = "Usage charges cannot be tested with a private application.")]
    public void Activates_Charges()
    {
        // Can't be tested.
    }

    [Fact(Skip = "Usage charges cannot be tested with a private application.")]
    public void Lists_Charges()
    {
        // Can't be tested.
    }

    [Fact(Skip = "Usage charges cannot be tested with a private application.")]
    public void Gets_Charges()
    {
        // Can't be tested.
    }

    [Fact(Skip = "Usage charges cannot be tested with a private application.")]
    public void Deletes_Charges()
    {
        // Can't be tested.    
    }
}