using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyRedirectService_Tests
{
    [Subject(typeof(RedirectService))]
    class When_listing_redirects
    {
        Establish context = () =>
        {
            Service = new RedirectService(Utils.MyShopifyUrl, Utils.AccessToken);

            for (int i = 0; i < 2; i++)
            {
                var redirect = Service.CreateAsync(new Redirect()
                {
                    Path = Guid.NewGuid().ToString(),
                    Target = "https://example.com"
                }).Await().AsTask.Result;

                Created.Add(redirect);
            }
        };

        Because of = () =>
        {
            Result = Service.ListAsync().Await().AsTask.Result;
        };

        It should_list_redirects = () =>
        {
            Result.ShouldNotBeNull();
            Result.Count().ShouldBeGreaterThanOrEqualTo(2);
        };

        Cleanup after = () =>
        {
            foreach (var redirect in Created)
            {
                Service.DeleteAsync(redirect.Id.Value).Await();
            }
        };

        static RedirectService Service;

        static List<Redirect> Created = new List<Redirect>();

        static IEnumerable<Redirect> Result;
    }
}
