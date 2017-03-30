using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyRecurringChargeService_Tests
{
    [Subject(typeof(RecurringChargeService))]
    class When_listing_recurring_charges
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
            Charges = Service.ListAsync().Await().AsTask.Result;
        };

        [Ignore("Charge tests cannot be run automatically; they require manual confirmation.")]
        It should_retrieve_a_list_of_recurring_charges = () =>
        {
            Charges.ShouldNotBeNull();
            Charges.Count().ShouldBeGreaterThanOrEqualTo(1);
        };

        Cleanup after = () =>
        {
            //Charges must have an active status before they can be deleted. Shopify will automatically delete an inactive charge after 48 hours.
        };

        static RecurringChargeService Service;

        static IEnumerable<RecurringCharge> Charges;

        static long ChargeId;
    }
}
