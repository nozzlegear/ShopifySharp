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
    public class When_creating_a_customer
    {
        Establish context = () =>
        {
            _Service = new ShopifyCustomerService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            _Result = _Service.CreateAsync(CustomerCreation.ValidCustomer, null).Await().AsTask.Result;
        };

        It should_create_a_customer = () =>
        {
            _Result.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {

        };

        static ShopifyCustomerService _Service;
        static ShopifyCustomer _Result;
    }
}
