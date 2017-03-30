using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyChargeService_Tests
{
    [Subject(typeof(ChargeService))]
    class When_listing_charges
    {
        Establish context = () =>
        {
            // NOTE: Creating a charge will fail if the access token used is for a private app. 
            // Only real apps can use the Shopify billing API.

            Service = new ChargeService(Utils.BillingMyShopifyUrl, Utils.BillingAccessToken);
            ChargeId = Service.CreateAsync(new Charge()
            {
                Name = "Lorem Ipsum Single Charge",
                Price = 123.45,
                Test = true,
            }).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            Charges = Service.ListAsync().Await().AsTask.Result;
        };

        [Ignore("Charge tests cannot be run automatically; they require manual confirmation.")]
        It should_retrieve_a_list_of_charges = () =>
        {
            Charges.ShouldNotBeNull();
            Charges.Count().ShouldBeGreaterThanOrEqualTo(1);
        };

        Cleanup after = () =>
        {
            //Charges cannot be deleted.
        };

        static ChargeService Service;

        static IEnumerable<Charge> Charges;

        static long ChargeId;
    }
}
