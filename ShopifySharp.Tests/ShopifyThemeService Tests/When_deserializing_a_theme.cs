using Machine.Specifications;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyThemeService_Tests
{
    [Subject(typeof(ShopifyThemeService))]
    class When_deserializing_a_theme
    {
        Establish context = () =>
        {

        };

        Because of = () =>
        {
            Theme1 = JsonConvert.DeserializeObject<ShopifyTheme>(Theme1Json);

            Theme2 = JsonConvert.DeserializeObject<ShopifyTheme>(Theme2Json);

            Theme3 = JsonConvert.DeserializeObject<ShopifyTheme>(Theme3Json);
        };

        It should_deserialize_a_theme = () =>
        {
            Theme1.Role.ShouldBeNull();

            Theme2.Role.ShouldBeNull();

            Theme3.Role.ShouldEqual("main");
        };

        Cleanup after = () =>
        {

        };

        static string Theme1Json { get; } = "{\"id\":10556555,\"name\":\"launchpad-star\",\"created_at\":\"2014-09-03T11:20:41-05:00\",\"updated_at\":\"2015-11-11T11:28:59-06:00\",\"role\":\"\",\"theme_store_id\":null,\"previewable\":true,\"processing\":false}";

        static string Theme2Json { get; } = "{\"id\":10556555,\"name\":\"launchpad-star\",\"created_at\":\"2014-09-03T11:20:41-05:00\",\"updated_at\":\"2015-11-11T11:28:59-06:00\",\"role\":\"unknown_value\",\"theme_store_id\":null,\"previewable\":true,\"processing\":false}";

        static string Theme3Json { get; } = "{\"id\":10556555,\"name\":\"launchpad-star\",\"created_at\":\"2014-09-03T11:20:41-05:00\",\"updated_at\":\"2015-11-11T11:28:59-06:00\",\"role\":\"main\",\"theme_store_id\":null,\"previewable\":true,\"processing\":false}";

        static ShopifyTheme Theme1 { get; set; }

        static ShopifyTheme Theme2 { get; set; }

        static ShopifyTheme Theme3 { get; set; }
    }
}
