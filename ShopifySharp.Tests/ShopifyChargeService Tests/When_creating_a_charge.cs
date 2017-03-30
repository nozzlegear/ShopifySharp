using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyChargeService_Tests
{
    [Subject(typeof(ShopifyChargeService))]
    class When_creating_a_charge
    {
        Establish context = () =>
        {
            Service = new ShopifyChargeService(Utils.BillingMyShopifyUrl, Utils.BillingAccessToken);
            Charge = new Charge()
            {
                Name = "Lorem Ipsum Single Charge",
                Price = 123.45,
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
        It should_create_a_charge = () =>
        {
            Charge.ConfirmationUrl.ShouldNotBeNull();
            Charge.Price.ShouldEqual(123.45);
            Charge.Test.ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            //Charges cannot be deleted.
        };

        static ShopifyChargeService Service;

        static Charge Charge;
    }
}
