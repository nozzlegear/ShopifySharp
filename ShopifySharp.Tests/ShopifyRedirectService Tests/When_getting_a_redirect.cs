using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyRedirectService_Tests
{
    [Subject(typeof(ShopifyRedirectService))]
    class When_getting_a_redirect
    {
        Establish context = () =>
        {
            Service = new ShopifyRedirectService(Utils.MyShopifyUrl, Utils.AccessToken);

            Id = Service.CreateAsync(new Redirect()
            {
                Path = Guid.NewGuid().ToString(),
                Target = "https://example.com"
            }).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            Result = Service.GetAsync(Id).Await().AsTask.Result;
        };

        It should_get_a_redirect = () =>
        {
            Result.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Id).Await();
        };

        static ShopifyRedirectService Service;

        static Redirect Result;

        static long Id;
    }
}
