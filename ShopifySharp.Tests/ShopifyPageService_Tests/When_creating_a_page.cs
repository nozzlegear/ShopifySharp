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
    public class When_creating_a_page
    {
        Establish context = () =>
        {
            Service = new ShopifyPageService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Page = Service.CreateAsync(PageCreation.CreateValidPages()).Await().AsTask.Result;
        };

        It should_create_a_page = () =>
        {
            Page.ShouldNotBeNull();
            Page.Title.ShouldNotBeNull();
            Page.Id.HasValue.ShouldBeTrue();
        };

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
