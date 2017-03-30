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
    public class When_updating_a_page_metafields
    {
        Establish context = () =>
        {
            Service = new PageService(Utils.MyShopifyUrl, Utils.AccessToken);
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

        static PageService Service;

        static ShopifySharp.Page Page;

        static ShopifySharp.MetaField MetaField;
    }
}
