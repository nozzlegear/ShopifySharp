using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyCustomerService))]
    public class When_retrieving_a_customer_with_fields
    {
        Establish context = () =>
        {
            _Service = new ShopifyCustomerService(Utils.MyShopifyUrl, Utils.AccessToken);

            //Create a customer to ensure this test always has a customer to retrieve.
            _Id = _Service.CreateAsync(CustomerCreation.CreateValidCustomer()).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            _Result = _Service.GetAsync(_Id, "first_name,last_name").Await().AsTask.Result;
        };

        It should_retrieve_a_customer_with_certain_fields = () =>
        {
            _Result.ShouldNotBeNull();
            string.IsNullOrEmpty(_Result.FirstName).ShouldBeFalse();
            string.IsNullOrEmpty(_Result.LastName).ShouldBeFalse();
            _Result.Addresses.ShouldBeNull();
            _Result.DefaultAddress.ShouldBeNull();
        };

        Cleanup after = () =>
        {
            _Service.DeleteAsync(_Id).Await();
        };

        static long _Id;
        static ShopifyCustomerService _Service;
        static ShopifyCustomer _Result;
    }
}
