using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyScriptTagService_Tests
{
    [Subject(typeof(ShopifyScriptTagService))]
    class When_getting_a_script_tag
    {
        Establish context = () =>
        {
            Service = new ShopifyScriptTagService(Utils.MyShopifyUrl, Utils.AccessToken);
            TagId = Service.CreateAsync(new ScriptTag()
            {
                Event = "onload",
                Src = "https://nozzlegear.com/test.js"
            }).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            Tag = Service.GetAsync(TagId).Await().AsTask.Result;
        };

        It should_get_a_script_tag = () =>
        {
            Tag.ShouldNotBeNull();
            Tag.Id.ShouldEqual(TagId);
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(TagId).Await();
        };

        static ShopifyScriptTagService Service;

        static ScriptTag Tag;

        static long TagId;
    }
}
