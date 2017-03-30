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
    public class When_updating_a_page_add_metafields
    {
        Establish context = () =>
        {
            Service = new PageService(Utils.MyShopifyUrl, Utils.AccessToken);
            Page = Service.CreateAsync(PageCreation.CreateValidPages()).Await().AsTask.Result;
        };

        Because of = () =>
        {
            MetaField = Service.UpdateMetafieldAsync(Page.Id.Value, PageCreation.CreateValidPageMetafield()).Await().AsTask.Result; 

        };

        It should_update_a_page_with_new_metafield = () =>
        {
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
