using Machine.Specifications;
using ShopifySharp.Filters;
using ShopifySharp.Tests.Test_Data;
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
            _Options = new ShopifyListFilter()
            {
                Limit = _Limit
            };

            // Create 4 customers to ensure this test always has customers to retrieve. Delete them during cleanup.
            for (int i = 0; i < 4; i++)
            {
                _CreatedCustomers.Add(_Service.CreateAsync(CustomerCreation.CreateValidCustomer()).Await().AsTask.Result);
            }
        };

        Because of = () =>
        {
            _Result = _Service.ListAsync(_Options).Await().AsTask.Result;
        };

        It should_only_list_1_customer = () =>
        {
            _Result.Count().ShouldBeLessThanOrEqualTo(_Limit);
        };

        Cleanup after = () =>
        {
            foreach (Customer customer in _CreatedCustomers)
            {
                _Service.DeleteAsync(customer.Id.Value).Await();
            }
        };

        static List<Customer> _CreatedCustomers = new List<Customer>();
        static int _Limit = 1;
        static ShopifyCustomerService _Service;
        static ShopifyListFilter _Options;
        static IEnumerable<Customer> _Result;
    }
}
