using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Integration.Rest.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests.Integration.Rest;

[Trait("Category", "Shop")]
public class ShopTests
{
    private readonly ITestOutputHelper _testOutputHelper;
    ShopService Service { get; } = new ShopService(Utils.MyShopifyUrl, Utils.AccessToken);

    public ShopTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
    }

    [Fact]
    public async Task Gets_Shops()
    {
        var shop = await Service.GetAsync();

        Assert.NotNull(shop);
        EmptyAssert.NotNullOrEmpty(shop.Name);
        EmptyAssert.NotNullOrEmpty(shop.PlanDisplayName);
        EmptyAssert.NotNullOrEmpty(shop.MyShopifyDomain);
    }

    [Fact(Skip = "Private applications cannot be uninstalled.")]
    public async Task Uninstalls_Apps()
    {
        bool threw = false;

        try
        {
            await Service.UninstallAppAsync();
        }
        catch (ShopifyException ex)
        {
            _testOutputHelper.WriteLine($"{nameof(Uninstalls_Apps)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }
}