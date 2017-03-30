using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyAssetService_Tests
{
    [Subject(typeof(ShopifyAssetService))]
    class When_updating_an_asset
    {
        Establish context = () =>
        {
            Service = new ShopifyAssetService(Utils.MyShopifyUrl, Utils.AccessToken);
            ThemeId = AssetUtils.GetValidThemeId();
            AssetKey = "templates/test.liquid";
            AssetValue = "<h1>Hello, world! I've been updated!</h1>";
            Asset = new Asset()
            {
                ContentType = "text/x-liquid",
                Value = "<h1>Hello, world!</h1>",
                Key = AssetKey
            };
            Service.CreateOrUpdateAsync(ThemeId, Asset).Await();

            Asset.Value = AssetValue;
        };

        Because of = () =>
        {
            Service.CreateOrUpdateAsync(ThemeId, Asset).Await();

            Asset = null;
            Asset = Service.GetAsync(ThemeId, AssetKey).Await().AsTask.Result;
        };

        It should_update_an_asset = () =>
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

        static Asset Asset;
    }
}
