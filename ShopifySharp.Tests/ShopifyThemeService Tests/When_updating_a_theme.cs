using Machine.Specifications;
using ShopifySharp.Tests.ShopifyThemeService_Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyThemeService_Tests
{
    [Subject(typeof(ShopifyThemeService))]
    class When_updating_a_themes
    {
        Establish context = () =>
        {
            Service = new ShopifyThemeService(Utils.MyShopifyUrl, Utils.AccessToken);
            Theme = Service.CreateAsync(ThemeCreation.CreateValidTheme(), ThemeCreation.ZipUrl).Await().AsTask.Result;

            int counter = 0;

            //Wait 30 seconds at max for the theme to finish processing. Its role cannot be updated before it's finished processing.
            while(Theme.Processing && counter < 6)
            {
                Theme = Service.GetAsync(Theme.Id.Value).Await().AsTask.Result;
                counter += 1;

                if (!Theme.Processing)
                {
                    continue;
                }

                Thread.Sleep(5000);
            }

            Theme.Name = UpdatedThemeName;
            Theme.Role = "main";
        };

        Because of = () =>
        {
            Theme = Service.UpdateAsync(Theme).Await().AsTask.Result;
        };

        It should_update_a_themes = () =>
        {
            Theme.Name.ShouldEqual(UpdatedThemeName);
            Theme.Role.ShouldEqual("main");
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Theme.Id.Value).Await();
        };

        static ShopifyThemeService Service;

        static Theme Theme;

        static string UpdatedThemeName = "Updated theme name.";
    }
}
