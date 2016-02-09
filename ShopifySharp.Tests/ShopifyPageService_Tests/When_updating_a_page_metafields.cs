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
    public class When_updating_a_page_metafields
    {
        Establish context = () =>
        {
            Service = new ShopifyPageService(Utils.MyShopifyUrl, Utils.AccessToken);
            Page = Service.CreateAsync(PageCreation.CreateValidPagesWithMetafield()).Await().AsTask.Result;
            Page.Metafields = Service.GetMetaFieldsAsync(Page.Id.Value).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Page.Metafields.FirstOrDefault().Value="updated value!";
            MetaField = Service.UpdateMetafieldAsync(Page.Id.Value, Page.Metafields.FirstOrDefault()).Await().AsTask.Result; 

        };

        It should_update_a_pages_metafields = () =>
        {
            Page.Metafields.ShouldNotBeEmpty();
            MetaField.Value.ShouldEqual("updated value!");
            MetaField.Id.HasValue.ShouldBeTrue();
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

        static ShopifyMetaField MetaField;
    }
}
