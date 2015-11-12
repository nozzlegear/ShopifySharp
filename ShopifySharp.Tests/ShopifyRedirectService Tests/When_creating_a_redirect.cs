using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyRedirectService_Tests
{
    [Subject(typeof(ShopifyRedirectService))]
    class When_creating_a_redirect
    {
        Establish context = () =>
        {
            Service = new ShopifyRedirectService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Result = Service.CreateAsync(new ShopifyRedirect()
            {
                Path = Guid.NewGuid().ToString(),
                Target = "https://example.com"
            }).Await().AsTask.Result;
        };

        It should_create_a_redirect = () =>
        {
            Result.ShouldNotBeNull();
            Result.Target.ShouldEqual("https://example.com/");
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Result.Id.Value).Await();
        };

        static ShopifyRedirectService Service;

        static ShopifyRedirect Result;
    }
}
