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
    public class When_deleting_a_customer
    {
        Establish context = () =>
        {
            _Service = new ShopifyCustomerService(Utils.MyShopifyUrl, Utils.AccessToken);

            //Create a customer to delete
            _CustomerId = _Service.CreateAsync(CustomerCreation.CreateValidCustomer()).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            try
            {
                _Service.DeleteAsync(_CustomerId).Await();
                _ThrewException = false;
            }
            catch (ShopifyException e)
            {
                _ThrewException = true;
            };
        };

        It should_delete_a_customer = () =>
        {
            _ThrewException.ShouldBeFalse();
        };

        Cleanup after = () =>
        {

        };

        static long _CustomerId;
        static bool _ThrewException = false;
        static ShopifyCustomerService _Service;
    }
}
