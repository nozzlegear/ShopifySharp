using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyScriptTagService_Tests
{
    [Subject(typeof(ScriptTagService))]
    class When_updating_a_script_tag
    {
        Establish context = () =>
        {
            Service = new ScriptTagService(Utils.MyShopifyUrl, Utils.AccessToken);
            OriginalTag = Service.CreateAsync(new ScriptTag()
            {
                Event = "onload",
                Src = "https://nozzlegear.com/test.js"
            }).Await().AsTask.Result;

            OriginalTag.Src = "https://nozzlegear.com/updated.js";
        };

        Because of = () =>
        {
            UpdatedTag = Service.UpdateAsync(OriginalTag).Await().AsTask.Result;
        };

        It should_update_a_script_tag = () =>
        {
            UpdatedTag.ShouldNotBeNull();
            UpdatedTag.Src.ShouldEqual("https://nozzlegear.com/updated.js");
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(OriginalTag.Id.Value).Await();
        };

        static ScriptTagService Service;

        static ScriptTag OriginalTag;

        static ScriptTag UpdatedTag;
    }
}
