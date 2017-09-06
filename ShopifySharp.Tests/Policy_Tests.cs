using System.Linq;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Policy")]
    public class Policy_Tests
    {
        private PolicyService _Service => new PolicyService(Utils.MyShopifyUrl, Utils.AccessToken);              

        [Fact]
        public async Task Lists_Orders()
        {
            var list = await _Service.ListAsync();

            Assert.NotNull(list);
            
            foreach(var policy in list)
            {
                EmptyAssert.NotNullOrEmpty(policy.Title);
                Assert.NotNull(policy.CreatedAt);
                Assert.NotNull(policy.UpdatedAt);
            }
        }
    }
}
