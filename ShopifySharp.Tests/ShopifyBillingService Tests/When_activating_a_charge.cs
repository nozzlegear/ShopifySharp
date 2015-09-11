using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyBillingService_Tests
{
    [Subject(typeof(ShopifyBillingService))]
    class When_activating_a_charge
    {
        Establish context = () =>
        {
            // NOTE: Creating a charge will fail if the access token used is for a private app. 
            // Only real apps can use the Shopify billing API.

            Service = new ShopifyBillingService(Utils.MyShopifyUrl, Utils.AccessToken);
            Charge = Service.CreateAsync(new ShopifyRecurringCharge()
            {
                Name = "Super Duper Charge",
                Price = 123.45
            }).Await().AsTask.Result;
        };

        Because of = () =>
        {
            // Not sure if this is is going to return a charge, and I'm not sure if the activation requires sending the entire charge.
            Charge = Service.ActivateAsync(Charge.Id.Value).Await().AsTask.Result;
        };

        It should_activate_a_charge = () =>
        {
            // NOTE: This test will require you to set a break point after creating the charge but before activating it, 
            // grab the confirmation url and manually accept it, then continue the test.
            Charge.ActivatedOn.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Charge.Id.Value).Await();
        };

        static ShopifyBillingService Service;

        static ShopifyRecurringCharge Charge;
    }
}
