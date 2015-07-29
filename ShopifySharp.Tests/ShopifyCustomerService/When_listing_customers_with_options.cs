using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyCustomerService))]
    public class When_listing_customers_with_options
    {
        Establish context = () =>
        {
            _Service = new ShopifyCustomerService(Utils.MyShopifyUrl, Utils.AccessToken);
            _Options = new ShopifyListOptions()
            {
                Limit = _Limit
            };

            // # # #
            // TODO: Create 4 customers to ensure we can always properly limit in this test. Delete them during cleanup.
            // # # #
        };

        Because of = () =>
        {
            _Result = _Service.ListAsync(_Options).Await().AsTask.Result;
        };

        It should_only_retrieve_a_limited_number_of_customers = () =>
        {
            _Result.Count().ShouldBeLessThanOrEqualTo(_Limit);
        };

        Cleanup after = () =>
        {

        };

        static int _Limit = 1;
        static ShopifyCustomerService _Service;
        static ShopifyListOptions _Options;
        static IEnumerable<ShopifyCustomer> _Result;
    }
}
