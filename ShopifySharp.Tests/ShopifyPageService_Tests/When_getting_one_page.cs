using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Page
{
    [Subject(typeof(ShopifyPageService))]
    public class When_getting_one_page
    {
        Establish context = () =>
        {
            Service = new ShopifyPageService(Utils.MyShopifyUrl, Utils.AccessToken);
            Page = Service.CreateAsync(PageCreation.CreateValidPages(), new ShopifyPageCreateOptions() { Published = false }).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Page = Service.GetAsync(Page.Id.Value).Await().AsTask.Result;
        };

        It should_retrieve_a_page = () => Page.ShouldNotBeNull();

        Cleanup after = () =>
        {
            if (Page != null)
            {
                Service.DeleteAsync(Page.Id.Value).Await();
            }
        };

        static ShopifyPageService Service;

        static ShopifySharp.Page Page;
    }
}
