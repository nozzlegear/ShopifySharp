using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyScriptTagService_Tests
{
    [Subject(typeof(ScriptTagService))]
    class When_counting_script_tags
    {
        Establish context = () =>
        {
            Service = new ScriptTagService(Utils.MyShopifyUrl, Utils.AccessToken);
            FilteredSrc = string.Format("https://nozzlegear.com/{0}/even.js", Guid.NewGuid().ToString());

            for (int i = 0; i < 5; i++)
            {
                string src = i % 2 == 0 ? FilteredSrc : "https://nozzlegear.com/odd.js";

                Tags.Add(Service.CreateAsync(new ScriptTag()
                {
                    Event = "onload",
                    Src = src
                }).Await().AsTask.Result);
            }
        };

        Because of = () =>
        {
            Count = Service.CountAsync().Await().AsTask.Result;
            FilteredCount = Service.CountAsync(FilteredSrc).Await().AsTask.Result;
        };

        It should_count_script_tags = () =>
        {
            Count.ShouldBeGreaterThanOrEqualTo(3);
            FilteredCount.ShouldEqual(3);
        };
        
        Cleanup after = () =>
        {
            foreach (var tag in Tags)
            {
                Service.DeleteAsync(tag.Id.Value).Await();
            }
        };

        static string FilteredSrc;

        static int Count;

        static int FilteredCount;

        static ScriptTagService Service;

        static List<ScriptTag> Tags = new List<ScriptTag>();
    }
}
