using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyRedirectService_Tests
{
    [Subject(typeof(ShopifyRedirectService))]
    class When_deleting_a_redirect
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
            Service.DeleteAsync(Id).Await();
        };

        It should_delete_a_redirect = () =>
        {
            //Passes if no exception was thrown.
        };

        Cleanup after = () =>
        {
            
        };

        static ShopifyRedirectService Service;

        static long Id;
    }
}
