using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyAssetService_Tests
{
    [Subject(typeof(ShopifyAssetService))]
    class When_listing_assets
    {
        Establish context = () =>
        {
            Service = new ShopifyAssetService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Assets = Service.ListAsync(AssetUtils.GetValidThemeId()).Await().AsTask.Result;
        };

        It should_list_assets = () =>
        {
            Assets.ShouldNotBeNull();
            Assets.Count().ShouldBeGreaterThan(0);
        };

        Cleanup after = () =>
        {

        };

        static ShopifyAssetService Service;

        static IEnumerable<ShopifyAsset> Assets;
    }
}
