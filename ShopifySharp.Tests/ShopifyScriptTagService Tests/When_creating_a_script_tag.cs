using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyScriptTagService_Tests
{
    [Subject(typeof(ScriptTagService))]
    class When_creating_a_script_tag
    {
        Establish context = () =>
        {
            Service = new ScriptTagService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Tag = Service.CreateAsync(new ScriptTag()
            {
                Event = "onload",
                Src  = "https://nozzlegear.com/test.js",
                DisplayScope = "online_store"
            }).Await().AsTask.Result;
        };

        It should_create_a_script_tag = () =>
        {
            Tag.ShouldNotBeNull();
            Tag.Src.ShouldEqual("https://nozzlegear.com/test.js");
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Tag.Id.Value).Await();
        };

        static ScriptTagService Service;

        static ScriptTag Tag;
    }
}
