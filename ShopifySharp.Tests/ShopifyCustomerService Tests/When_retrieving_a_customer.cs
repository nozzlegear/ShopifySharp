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
    public class When_retrieving_a_customer
    {
        Establish context = () =>
        {
            _Service = new ShopifyCustomerService(Utils.MyShopifyUrl, Utils.AccessToken);

            //Create a customer to ensure this test always has a customer to retrieve.
            _Id = _Service.CreateAsync(CustomerCreation.CreateValidCustomer()).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            _Result = _Service.GetAsync(_Id).Await().AsTask.Result;
        };

        It should_retrieve_a_customer = () =>
        {
            _Result.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {
            _Service.DeleteAsync(_Id).Await();
        };

        static long _Id;
        static ShopifyCustomerService _Service;
        static Customer _Result;
    }
}
