using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyBillingService_Tests
{
    [Subject(typeof(ShopifyBillingService))]
    class When_creating_a_charge_with_trial
    {
        Establish context = () =>
        {
            Service = new ShopifyBillingService(Utils.MyShopifyUrl, Utils.AccessToken);
            Charge = new ShopifyRecurringCharge()
            {
                Name = "Super Duper Charge With Trial",
                Price = 123.45,
                TrialDays = 21,
                Test = true
            };
        };

        Because of = () =>
        {
            // NOTE: Creating a charge will fail if the access token used is for a private app. 
            // Only real apps can use the Shopify billing API.

            Charge = Service.CreateAsync(Charge).Await().AsTask.Result;
        };

        It should_create_a_charge_with_trial = () =>
        {
            Charge.ConfirmationUrl.ShouldNotBeNull();
            Charge.Price.ShouldEqual(123.45);
            Charge.Test.ShouldBeTrue();
            Charge.TrialEndsOn.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {
            if (Charge.Id.HasValue)
            {
                Service.DeleteAsync(Charge.Id.Value).Await();
            }
        };

        static ShopifyBillingService Service;
        static ShopifyRecurringCharge Charge;
    }
}
