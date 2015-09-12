using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyRecurringChargeService_Tests
{
    [Subject(typeof(ShopifyRecurringChargeService))]
    class When_listing_charges
    {
        Establish context = () =>
        {
            // NOTE: Creating a charge will fail if the access token used is for a private app. 
            // Only real apps can use the Shopify billing API.

            Service = new ShopifyRecurringChargeService(Utils.BillingMyShopifyUrl, Utils.BillingAccessToken);
            ChargeId = Service.CreateAsync(new ShopifyRecurringCharge()
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

        It should_retrieve_a_list_of_charges = () =>
        {
            Charges.ShouldNotBeNull();
            Charges.Count().ShouldBeGreaterThanOrEqualTo(1);
        };

        Cleanup after = () =>
        {
            //Charges must have an active status before they can be deleted. Shopify will automatically delete an inactive charge after 48 hours.
        };

        static ShopifyRecurringChargeService Service;

        static IEnumerable<ShopifyRecurringCharge> Charges;

        static long ChargeId;
    }
}
