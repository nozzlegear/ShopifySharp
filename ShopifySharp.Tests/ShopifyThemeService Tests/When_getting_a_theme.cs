using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyThemeService_Tests
{
    [Subject(typeof(ShopifyThemeService))]
    class When_getting_a_theme
    {
        Establish context = () =>
        {
            Service = new ShopifyThemeService(Utils.MyShopifyUrl, Utils.AccessToken);

            ThemeId = Service.ListAsync().Await().AsTask.Result.First().Id.Value;
        };

        Because of = () =>
        {
            Theme = Service.GetAsync(ThemeId).Await().AsTask.Result;
        };

        It should_get_a_theme = () =>
        {
            Theme.ShouldNotBeNull();
            Theme.Role.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {

        };

        static ShopifyThemeService Service { get; set; }

        static long ThemeId { get; set; }

        static Theme Theme { get; set; }
    }
}
