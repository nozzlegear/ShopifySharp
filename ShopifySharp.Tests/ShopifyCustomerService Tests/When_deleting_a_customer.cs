using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests
{
    [Subject(typeof(CustomerService))]
    public class When_deleting_a_customer
    {
        Establish context = () =>
        {
            _Service = new CustomerService(Utils.MyShopifyUrl, Utils.AccessToken);

            //Create a customer to delete
            _CustomerId = _Service.CreateAsync(CustomerCreation.CreateValidCustomer()).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            try
            {
                _Service.DeleteAsync(_CustomerId).Await();
            }
            catch (ShopifyException e)
            {
                _Exception = e;
            }
        };

        It should_delete_a_customer = () =>
        {
            _Exception.ShouldBeNull();
        };

        Cleanup after = () =>
        {

        };

        static long _CustomerId;
        
        static CustomerService _Service;

        static ShopifyException _Exception;
    }
}
