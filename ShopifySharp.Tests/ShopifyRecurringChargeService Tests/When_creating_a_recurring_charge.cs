using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyRecurringChargeService_Tests
{
    [Subject(typeof(ShopifyRecurringChargeService))]
    class When_creating_a_recurring_charge
    {
        Establish context = () =>
        {
            Service = new ShopifyRecurringChargeService(Utils.BillingMyShopifyUrl, Utils.BillingAccessToken);
            Charge = new RecurringCharge()
            {
                Name = "Lorem Ipsum Plan",
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

        [Ignore("Charge tests cannot be run automatically; they require manual confirmation.")]
        It should_create_a_recurring_charge = () =>
        {
            Charge.ConfirmationUrl.ShouldNotBeNull();
            Charge.Price.ShouldEqual(123.45);
            Charge.Test.ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            //Charges must have an active status before they can be deleted. Shopify will automatically delete an inactive charge after 48 hours.
        };

        static ShopifyRecurringChargeService Service;

        static RecurringCharge Charge;
    }
}
