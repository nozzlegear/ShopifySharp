using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyThemeService_Tests
{
    [Subject(typeof(ShopifyThemeService))]
    class When_listing_themes
    {
        Establish context = () =>
        {
            Service = new ShopifyThemeService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Result = Service.ListAsync().Await().AsTask.Result;
        };

        It should_list_themes = () =>
        {
            Result.Count().ShouldBeGreaterThanOrEqualTo(1);
        };

        Cleanup after = () =>
        {

        };

        static ShopifyThemeService Service;

        static IEnumerable<Theme> Result;
    }
}
