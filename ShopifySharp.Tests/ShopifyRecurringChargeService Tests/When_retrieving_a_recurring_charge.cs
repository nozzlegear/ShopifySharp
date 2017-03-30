using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyRecurringChargeService_Tests
{
    [Subject(typeof(RecurringChargeService))]
    class When_retrieving_a_recurring_charge
    {
        Establish context = () =>
        {
            // NOTE: Creating a charge will fail if the access token used is for a private app. 
            // Only real apps can use the Shopify billing API.

            Service = new RecurringChargeService(Utils.BillingMyShopifyUrl, Utils.BillingAccessToken);
            ChargeId = Service.CreateAsync(new RecurringCharge()
            {
                Name = "Lorem Ipsum Plan",
                Price = 123.45,
                Test = true,
            }).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            Charge = Service.GetAsync(ChargeId).Await().AsTask.Result;
        };

        [Ignore("Charge tests cannot be run automatically; they require manual confirmation.")]
        It should_retrieve_a_recurring_charge = () =>
        {
            Charge.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(ChargeId).Await();
        };

        static RecurringChargeService Service;

        static RecurringCharge Charge;

        static long ChargeId;
    }
}
