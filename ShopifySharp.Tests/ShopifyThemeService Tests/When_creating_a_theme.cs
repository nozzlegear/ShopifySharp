using Machine.Specifications;
using ShopifySharp.Tests.ShopifyThemeService_Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyThemeService_Tests
{
    [Subject(typeof(ShopifyThemeService))]
    class When_creating_a_themes
    {
        Establish context = () =>
        {
            Service = new ShopifyThemeService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Theme = Service.CreateAsync(ThemeCreation.CreateValidTheme(), "").Await().AsTask.Result;
        };

        It should_create_a_theme = () =>
        {
            Theme.Id.HasValue.ShouldBeTrue();
            Theme.Role.ShouldEqual("unpublished");
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Theme.Id.Value).Await();
        };

        static ShopifyThemeService Service;

        static Theme Theme;
    }
}
