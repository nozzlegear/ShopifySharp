using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyRedirectService_Tests
{
    [Subject(typeof(ShopifyRedirectService))]
    class When_updating_a_redirect
    {
        Establish context = () =>
        {
            Service = new ShopifyRedirectService(Utils.MyShopifyUrl, Utils.AccessToken);
            Result = Service.CreateAsync(new ShopifyRedirect()
            {
                Path = Guid.NewGuid().ToString(),
                Target = "https://example.com"
            }).Await().AsTask.Result;

            NewTarget = "https://example.com/" + Guid.NewGuid().ToString() + "/";

            Result.Target = NewTarget;
        };

        Because of = () =>
        {
            Result = Service.UpdateAsync(Result).Await().AsTask.Result;
        };

        It should_create_a_redirect = () =>
        {
            Result.ShouldNotBeNull();
            Result.Target.ShouldEqual(NewTarget);
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Result.Id.Value).Await();
        };

        static ShopifyRedirectService Service;

        static ShopifyRedirect Result;

        static string NewTarget;
    }
}
