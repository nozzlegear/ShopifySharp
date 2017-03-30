using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyScriptTagService_Tests
{
    [Subject(typeof(ShopifyScriptTagService))]
    class When_deleting_a_script_tag
    {
        Establish context = () =>
        {
            Service = new ShopifyScriptTagService(Utils.MyShopifyUrl, Utils.AccessToken);
            Tag = Service.CreateAsync(new ScriptTag()
            {
                Event = "onload",
                Src = "https://nozzlegear.com/test.js"
            }).Await().AsTask.Result;
        };

        Because of = () =>
        {
            try
            {
                Service.DeleteAsync(Tag.Id.Value).Await();
            }
            catch(Exception e)
            {
                Ex = e;
            }
        };

        It should_delete_a_script_tag = () =>
        {
            Ex.ShouldBeNull();
        };

        Cleanup after = () =>
        {

        };

        static ShopifyScriptTagService Service;

        static ScriptTag Tag;

        static Exception Ex;
    }
}
