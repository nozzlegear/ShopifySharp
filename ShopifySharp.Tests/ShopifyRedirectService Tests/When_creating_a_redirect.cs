using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyRedirectService_Tests
{
    [Subject(typeof(RedirectService))]
    class When_creating_a_redirect
    {
        Establish context = () =>
        {
            Service = new RedirectService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Result = Service.CreateAsync(new Redirect()
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

        static RedirectService Service;

        static Redirect Result;
    }
}
