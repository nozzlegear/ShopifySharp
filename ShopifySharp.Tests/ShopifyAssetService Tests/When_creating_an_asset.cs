using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyAssetService_Tests
{
    [Subject(typeof(ShopifyAssetService))]
    class When_creating_an_asset
    {
        Establish context = () =>
        {
            Service = new ShopifyAssetService(Utils.MyShopifyUrl, Utils.AccessToken);
            ThemeId = AssetUtils.GetValidThemeId();
            AssetKey = "templates/test.liquid";
            AssetValue = "<h1>Hello, world!</h1>";
            Asset = new ShopifyAsset()
            {
                ContentType = "text/x-liquid",
                Value = AssetValue,
                Key = AssetKey
            };
        };

        Because of = () =>
        {
            Service.CreateOrUpdateAsync(ThemeId, Asset).Await();

            Asset = null;
            Asset = Service.GetAsync(ThemeId, AssetKey).Await().AsTask.Result;
        };

        It should_create_an_asset = () =>
        {
            Asset.ShouldNotBeNull();
            Asset.Key.ShouldEqual(AssetKey);
            Asset.Value.ShouldEqual(AssetValue);
            Asset.ThemeId.ShouldEqual(ThemeId);
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(ThemeId, AssetKey).Await();
        };

        static ShopifyAssetService Service;

        static long ThemeId;

        static string AssetKey;

        static string AssetValue;

        static ShopifyAsset Asset;
    }
}
