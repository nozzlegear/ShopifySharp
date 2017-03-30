using Machine.Specifications;
using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyScriptTagService_Tests
{
    [Subject(typeof(ShopifyScriptTagService))]
    class When_listing_script_tags
    {
        Establish context = () =>
        {
            Service = new ShopifyScriptTagService(Utils.MyShopifyUrl, Utils.AccessToken);

            for (int i = 0; i < 5; i++)
            {
                string src = i % 2 == 0 ? FilteredSrc : "https://nozzlegear.com/odd.js";

                Service.CreateAsync(new ScriptTag()
                {
                    Event = "onload",
                    Src = src
                }).Await();
            }
        };

        Because of = () =>
        {
            Tags = Service.ListAsync().Await().AsTask.Result;
            FilteredTags = Service.ListAsync(new ShopifyScriptTagFilter() {
                Src = FilteredSrc
            }).Await().AsTask.Result;
        };

        It should_list_script_tags = () =>
        {
            Tags.Count().ShouldBeGreaterThanOrEqualTo(5);
            FilteredTags.All(x => x.Src == FilteredSrc).ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            foreach (var tag in Tags)
            {
                Service.DeleteAsync(tag.Id.Value).Await();
            }
        };

        static string FilteredSrc = "https://nozzlegear.com/even.js";

        static ShopifyScriptTagService Service;

        static IEnumerable<ScriptTag> Tags;

        static IEnumerable<ScriptTag> FilteredTags;
    }
}
