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
    public class When_updating_a_customer_with_options
    {
        Establish context = () =>
        {
            _Service = new ShopifyCustomerService(Utils.MyShopifyUrl, Utils.AccessToken);

            //Create a customer to update
            _Customer = _Service.CreateAsync(CustomerCreation.CreateValidCustomer()).Await().AsTask.Result;

            //Change the customer's email address
            _Customer.Email = "test-update@example.com";
        };

        Because of = () =>
        {
            _Customer = _Service.UpdateAsync(_Customer, new ShopifyCustomerUpdateOptions()
            {
                Password = "loktarogar",
                PasswordConfirmation = "loktarogar"
            }).Await().AsTask.Result;
        };

        It should_update_the_customer_with_options = () =>
        {
            _Customer.Email.Equals("test-update@example.com").ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            _Service.DeleteAsync(_Customer.Id.Value).Await();
        };

        static ShopifyCustomerService _Service;
        static ShopifyCustomer _Customer;
    }
}
