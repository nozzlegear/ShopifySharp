using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyBillingService_Tests
{
    [Subject(typeof(ShopifyBillingService))]
    class When_retrieving_a_charge
    {
        Establish context = () =>
        {
            // NOTE: Creating a charge will fail if the access token used is for a private app. 
            // Only real apps can use the Shopify billing API.

            Service = new ShopifyBillingService(Utils.MyShopifyUrl, Utils.AccessToken);
            ChargeId = Service.CreateAsync(new ShopifyRecurringCharge()
            {
                Name = "Super Duper Charge",
                Price = 123.45
            }).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            Charge = Service.GetAsync(ChargeId).Await().AsTask.Result;
        };

        It should_retrieve_a_charge = () =>
        {
            Charge.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(ChargeId).Await();
        };

        static ShopifyBillingService Service;

        static ShopifyRecurringCharge Charge;

        static long ChargeId;
    }
}
