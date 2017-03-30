using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyCustomerService))]
    public class When_listing_customers
    {
        Establish context = () =>
        {
            _Service = new ShopifyCustomerService(Utils.MyShopifyUrl, Utils.AccessToken);

            // Create 4 customers to ensure this test always has customers to retrieve. Delete them during cleanup.
            for(int i = 0; i < 4; i++)
            {
                _CreatedCustomers.Add(_Service.CreateAsync(CustomerCreation.CreateValidCustomer()).Await().AsTask.Result);
            }
        };

        Because of = () =>
        {
            //MSpec test suite does not support async/await
            _Result = _Service.ListAsync().Await().AsTask.Result;
        };

        It should_retrieve_a_list_of_customers = () =>
        {
            _Result.ShouldNotBeNull();
            _Result.Count().ShouldBeGreaterThanOrEqualTo(_CreatedCustomers.Count);
        };

        Cleanup after = () =>
        {
            foreach(Customer customer in _CreatedCustomers)
            {
                _Service.DeleteAsync(customer.Id.Value).Await();
            }
        };

        static List<Customer> _CreatedCustomers = new List<Customer>();
        static ShopifyCustomerService _Service;
        static IEnumerable<Customer> _Result;
    }
}
