using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace ShopifySharp.Tests.Page
{
    [Subject(typeof(ShopifyPageService))]
    public class When_deleting_a_page
    {
        Establish context = () =>
        {
            Service = new ShopifyPageService(Utils.MyShopifyUrl, Utils.AccessToken);
            Page = Service.CreateAsync(PageCreation.CreateValidPages(), new ShopifyPageCreateOptions() { Published = false }).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Service.DeleteAsync(Page.Id.Value).Await();
        };

        It should_delete_a_page = () =>
        {
            //Passes if no exception was thrown.
        };

        static ShopifyPageService Service;

        static ShopifyPage Page;
    }
}
