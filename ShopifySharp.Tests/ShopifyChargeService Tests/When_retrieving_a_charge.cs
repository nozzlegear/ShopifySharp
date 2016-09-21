using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyChargeService_Tests
{
    [Subject(typeof(ShopifyChargeService))]
    class When_retrieving_a_charge
    {
        Establish context = () =>
        {
            // NOTE: Creating a charge will fail if the access token used is for a private app. 
            // Only real apps can use the Shopify billing API.

            Service = new ShopifyChargeService(Utils.BillingMyShopifyUrl, Utils.BillingAccessToken);
            ChargeId = Service.CreateAsync(new ShopifyCharge()
            {
                Name = "Lorem Ipsum Single Charge",
                Price = 123.45,
                Test = true,
            }).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            Charge = Service.GetAsync(ChargeId).Await().AsTask.Result;
        };

        [Ignore("Charge tests cannot be run automatically; they require manual confirmation.")]
        It should_retrieve_a_charge = () =>
        {
            Charge.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {
            //Charges cannot be deleted.
        };

        static ShopifyChargeService Service;

        static ShopifyCharge Charge;

        static long ChargeId;
    }
}
