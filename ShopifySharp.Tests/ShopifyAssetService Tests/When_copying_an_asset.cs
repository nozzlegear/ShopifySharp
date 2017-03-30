using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyAssetService_Tests
{
    [Subject(typeof(AssetService))]
    class When_copying_an_asset
    {
        Establish context = () =>
        {
            Service = new AssetService(Utils.MyShopifyUrl, Utils.AccessToken);
            ThemeId = AssetUtils.GetValidThemeId();
            OriginalAsset = Service.GetAsync(ThemeId, "templates/index.liquid").Await().AsTask.Result;
            AssetKey = "templates/test-index-copy.liquid";

            Asset = new Asset()
            {
                Key = AssetKey,
                SourceKey = OriginalAsset.Key
            };
        };

        Because of = () =>
        {
            Service.CreateOrUpdateAsync(ThemeId, Asset).Await();

            Asset = null;
            Asset = Service.GetAsync(ThemeId, AssetKey).Await().AsTask.Result;
        };

        It should_copy_an_asset = () =>
        {
            Asset.ShouldNotBeNull();
            Asset.Key.ShouldEqual(AssetKey);
            Asset.Value.ShouldEqual(OriginalAsset.Value);
            Asset.ContentType.ShouldEqual(OriginalAsset.ContentType);
            Asset.ThemeId.ShouldEqual(ThemeId);
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(ThemeId, AssetKey).Await();
        };

        static AssetService Service;

        static long ThemeId;

        static string AssetKey;

        static Asset OriginalAsset;

        static Asset Asset;
    }
}
