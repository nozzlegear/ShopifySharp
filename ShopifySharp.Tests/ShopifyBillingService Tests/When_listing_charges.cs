using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyBillingService_Tests
{
    [Subject(typeof(ShopifyBillingService))]
    class When_listing_charges
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
            Charges = Service.ListAsync().Await().AsTask.Result;
        };

        It should_retrieve_a_charge = () =>
        {
            Charges.ShouldNotBeNull();
            Charges.Count().ShouldBeGreaterThanOrEqualTo(1);
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(ChargeId).Await();
        };

        static ShopifyBillingService Service;

        static IEnumerable<ShopifyRecurringCharge> Charges;

        static long ChargeId;
    }
}
