using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests;

[Trait("Category", "ApplicationCredit")]
public class ApplicationCreditTests
{
    ApplicationCreditService Service { get; } = new ApplicationCreditService(Utils.MyShopifyUrl, Utils.AccessToken);

    public ApplicationCreditTests()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
    }

    [Fact(Skip = "Application Credits cannot be tested because they're unusable in a private application.")]
    public async Task Creates_An_Application_Credit()
    {
        var credit = await Service.CreateAsync(new ApplicationCredit()
        {
            Description = "Refund for Foo",
            Amount = 10.00m,
            Test = true,
        });

        Assert.NotNull(credit);
        Assert.True(credit.Id.HasValue);
        EmptyAssert.NotNullOrEmpty(credit.Description);
        Assert.True(credit.Test.Value);
        Assert.True(credit.Amount > 0);
    }
}