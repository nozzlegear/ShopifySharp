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
    public class When_creating_a_customer_with_options
    {
        Establish context = () =>
        {
            _Service = new ShopifyCustomerService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            _Result = _Service.CreateAsync(CustomerCreation.CreateValidCustomer(), new ShopifyCustomerCreateOptions()
            {
                Password = "loktarogar",
                PasswordConfirmation = "loktarogar",
                SendEmailInvite = true,
                SendWelcomeEmail = true
            }).Await().AsTask.Result;
        };

        It should_create_a_customer_with_options = () =>
        {
            _Result.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {
            _Service.DeleteAsync(_Result.Id.Value).Await();
        };

        static ShopifyCustomerService _Service;
        static Customer _Result;
    }
}
