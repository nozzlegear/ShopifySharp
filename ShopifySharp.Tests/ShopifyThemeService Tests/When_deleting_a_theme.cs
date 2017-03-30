using Machine.Specifications;
using ShopifySharp.Tests.ShopifyThemeService_Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyThemeService_Tests
{
    [Subject(typeof(ThemeService))]
    class When_deleting_a_themes
    {
        Establish context = () =>
        {
            Service = new ThemeService(Utils.MyShopifyUrl, Utils.AccessToken);
            ThemeId = Service.CreateAsync(ThemeCreation.CreateValidTheme(), "").Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            Service.DeleteAsync(ThemeId).Await();
        };

        It should_delete_a_theme = () =>
        {
            //Passes if no exception was thrown.
        };

        Cleanup after = () =>
        {

        };

        static ThemeService Service;

        static long ThemeId;
    }
}
