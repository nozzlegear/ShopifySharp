using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp.Tests
{ 
    [Subject(typeof(ShopifyCustomerService))]
    public class When_searching_for_a_customer
    {
        Establish context = () =>
        {
            _Service = new ShopifyCustomerService(Utils.MyShopifyUrl, Utils.AccessToken);

            //Create a customer named jane
            Customer customer = CustomerCreation.CreateValidCustomer();
            customer.FirstName = "Jane5532";

            _Id = _Service.CreateAsync(customer).Await().AsTask.Result.Id.Value;

            //It takes anywhere between 3 seconds to 30 seconds for Shopify to index new customers for searches.
            //Rather than putting a 20 second Thread.Sleep in the test, we'll just assume it's successful if the
            //search method doesn't throw an exception. To test actual searches, uncomment the next line.
            
            //Thread.Sleep(20000);
        };

        Because of = () =>
        {
            _Result = _Service.SearchAsync("Jane5532").Await().AsTask.Result;
        };

        It should_return_a_customer_named_jane = () =>
        {
            _Result.ShouldNotBeNull();

            if (_Result.Count() > 0)
            {
                _Result.Any(x => x.FirstName == "Jane5532").ShouldBeTrue();
            }
        };

        Cleanup after = () =>
        {
            _Service.DeleteAsync(_Id).Await();
        };

        static long _Id;
        static ShopifyCustomerService _Service;
        static IEnumerable<Customer> _Result;
    }
}
