using Machine.Specifications;
using System;
using System.Collections.Generic;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyCustomerService))]
    public class When_listing_customers
    {
        Establish context = () =>
        {
            _Service = new ShopifyCustomerService(Utils.MyShopifyUrl, Utils.AccessToken);

            // # # #
            // TODO: Create 4 customers to ensure this test always has customers to retrieve. Delete them during cleanup.
            // # # #
        };

        Because of = () =>
        {
            //MSpec test suite does not support async/await
            _Result = _Service.ListAsync().Await().AsTask.Result;
        };

        It should_retrieve_a_list_of_customers = () =>
        {
            _Result.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {

        };

        static ShopifyCustomerService _Service;
        static IEnumerable<ShopifyCustomer> _Result;
    }
}
