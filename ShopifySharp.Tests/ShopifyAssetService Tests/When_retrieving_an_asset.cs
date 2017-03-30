using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyAssetService_Tests
{
    [Subject(typeof(AssetService))]
    class When_retrieving_assets
    {
        Establish context = () =>
        {
            Service = new AssetService(Utils.MyShopifyUrl, Utils.AccessToken);
            ThemeId = AssetUtils.GetValidThemeId();
            AssetKey = Service.ListAsync(ThemeId).Await().AsTask.Result.OrderBy(x => new Guid()).First().Key;
        };

        Because of = () =>
        {
            Asset = Service.GetAsync(ThemeId, AssetKey).Await().AsTask.Result;
        };

        It should_retrieve_an_asset = () =>
        {
            Asset.ShouldNotBeNull();
            Asset.Key.ShouldEqual(AssetKey);
            Asset.ThemeId.ShouldEqual(ThemeId);
        };

        Cleanup after = () =>
        {

        };

        static AssetService Service;

        static long ThemeId;

        static string AssetKey;

        static Asset Asset;
    }
}
