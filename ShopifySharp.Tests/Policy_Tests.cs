using System.Linq;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Policy")]
    public class Policy_Tests
    {
        PolicyService Service { get; } = new PolicyService(Utils.MyShopifyUrl, Utils.AccessToken);

        public Policy_Tests()
        {
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());
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
}
