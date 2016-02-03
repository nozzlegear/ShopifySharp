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
    public class When_creating_a_page_with_metafields
    {
        Establish context = () =>
        {
            Service = new ShopifyPageService(Utils.MyShopifyUrl, Utils.AccessToken);
            Page = Service.CreateAsync(PageCreation.CreateValidPagesWithMetafield()).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Page.Metafields = Service.GetMetaFieldsAsync(Page.Id.Value).Await().AsTask.Result;
        };

        It should_create_a_page = () =>
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

        static ShopifyPageService Service;

        static ShopifyPage Page;
    }
}
