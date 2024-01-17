using System.Threading.Tasks;
using JetBrains.Annotations;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests.Policies;

[Trait("Category", "Policy")]
[TestSubject(typeof(PolicyService))]
public class PolicyServiceTests
{
    PolicyService Service { get; } = new PolicyService(Utils.MyShopifyUrl, Utils.AccessToken);

    public PolicyServiceTests()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
    }

    [Fact]
    public async Task Lists_Orders()
    {
        var list = await Service.ListAsync();

        Assert.NotNull(list);

        foreach (var policy in list)
        {
            EmptyAssert.NotNullOrEmpty(policy.Title);
            Assert.NotNull(policy.CreatedAt);
            Assert.NotNull(policy.UpdatedAt);
        }
    }
}
