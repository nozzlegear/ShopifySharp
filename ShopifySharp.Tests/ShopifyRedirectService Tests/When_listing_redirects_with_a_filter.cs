using Machine.Specifications;
using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyRedirectService_Tests
{
    [Subject(typeof(ShopifyRedirectService))]
    class When_listing_redirects_with_a_filter
    {
        Establish context = () =>
        {
            Service = new ShopifyRedirectService(Utils.MyShopifyUrl, Utils.AccessToken);
            FilteredTarget = "https://example.com/" + Guid.NewGuid().ToString();
            FilteredPath = Guid.NewGuid().ToString();

            for (int i = 1; i < 5; i++)
            {
                var redirect = Service.CreateAsync(new Redirect()
                {
                    Path = i == 3 ? FilteredPath : Guid.NewGuid().ToString(),
                    Target = i % 2 == 0 ? FilteredTarget : "https://example.com"
                }).Await().AsTask.Result;

                Created.Add(redirect);
            }
        };

        Because of = () =>
        {
            TargetResult = Service.ListAsync(new ShopifyRedirectFilter()
            {
                Target = FilteredTarget
            }).Await().AsTask.Result;

            PathResult = Service.ListAsync(new ShopifyRedirectFilter()
            {
                Path = FilteredPath
            }).Await().AsTask.Result;
        };

        It should_list_redirects_with_a_filter = () =>
        {
            TargetResult.ShouldNotBeNull();
            PathResult.ShouldNotBeNull();

            TargetResult.Count().ShouldEqual(2);
            PathResult.Count().ShouldEqual(1);
        };

        Cleanup after = () =>
        {
            foreach (var redirect in Created)
            {
                Service.DeleteAsync(redirect.Id.Value).Await();
            }
        };

        static ShopifyRedirectService Service;

        static List<Redirect> Created = new List<Redirect>();

        static string FilteredPath;

        static string FilteredTarget;

        static IEnumerable<Redirect> PathResult;

        static IEnumerable<Redirect> TargetResult;
    }
}
