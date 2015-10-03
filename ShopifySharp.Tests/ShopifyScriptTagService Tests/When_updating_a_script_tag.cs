using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyScriptTagService_Tests
{
    [Subject(typeof(ShopifyScriptTagService))]
    class When_updating_a_script_tag
    {
        Establish context = () =>
        {
            Service = new ShopifyScriptTagService(Utils.MyShopifyUrl, Utils.AccessToken);
            OriginalTag = Service.CreateAsync(new ShopifyScriptTag()
            {
                Event = Enums.ShopifyScriptTagEvent.Onload,
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

        static ShopifyScriptTagService Service;

        static ShopifyScriptTag OriginalTag;

        static ShopifyScriptTag UpdatedTag;
    }
}
