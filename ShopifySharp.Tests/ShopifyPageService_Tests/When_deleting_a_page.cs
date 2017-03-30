using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Page
{
    [Subject(typeof(PageService))]
    public class When_deleting_a_page
    {
        Establish context = () =>
        {
            Service = new PageService(Utils.MyShopifyUrl, Utils.AccessToken);
            Page = Service.CreateAsync(PageCreation.CreateValidPages(), new PageCreateOptions() { Published = false }).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Service.DeleteAsync(Page.Id.Value).Await();
        };

        It should_delete_a_page = () =>
        {
            //Passes if no exception was thrown.
        };

        static PageService Service;

        static ShopifySharp.Page Page;
    }
}
