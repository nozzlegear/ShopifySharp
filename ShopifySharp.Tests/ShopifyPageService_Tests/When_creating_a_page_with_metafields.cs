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
    public class When_creating_a_page_with_metafields
    {
        Establish context = () =>
        {
            Service = new PageService(Utils.MyShopifyUrl, Utils.AccessToken);
            Page = Service.CreateAsync(PageCreation.CreateValidPagesWithMetafield()).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Page.Metafields = Service.GetMetaFieldsAsync(Page.Id.Value).Await().AsTask.Result;
        };

        It should_create_a_page_with_metafields = () =>
        {
            Page.Metafields.ShouldNotBeEmpty();
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

        static PageService Service;

        static ShopifySharp.Page Page;
    }
}
