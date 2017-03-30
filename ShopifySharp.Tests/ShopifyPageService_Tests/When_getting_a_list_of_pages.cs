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
    public class When_getting_a_list_of_pages
    {
        Establish context = () =>
        {
            Service = new PageService(Utils.MyShopifyUrl, Utils.AccessToken);

            for (var i = 0; i < 3; i++)
            {
                var page = Service.CreateAsync(PageCreation.CreateValidPages(), new PageCreateOptions()
                {
                    Published = false
                }).Await().AsTask.Result;

                PageIds.Add(page.Id.Value);
            }
        };

        Because of = () =>
        {
            Pages = Service.ListAsync().Await().AsTask.Result;
        };

        It should_list_pages = () =>
        {
            Pages.Count().ShouldBeGreaterThanOrEqualTo(PageIds.Count);
        };

        Cleanup after = () =>
        {
            foreach (var id in PageIds)
            {
                Service.DeleteAsync(id).Await();
            }
        };

        static PageService Service;

        static List<long> PageIds = new List<long>();

        static IEnumerable<ShopifySharp.Page> Pages;
    }
}
