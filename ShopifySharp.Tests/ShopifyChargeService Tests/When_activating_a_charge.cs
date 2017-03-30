using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyChargeService_Tests
{
    [Subject(typeof(ShopifyChargeService))]
    class When_activating_a_charge
    {
        Establish context = () =>
        {
            // NOTE: Creating a charge will fail if the access token used is for a private app. 
            // Only real apps can use the Shopify billing API.

            Service = new ShopifyChargeService(Utils.BillingMyShopifyUrl, Utils.BillingAccessToken);
            Charge = Service.CreateAsync(new Charge()
            {
                Name = "Lorem Ipsum Single Charge",
                Price = 123.45,
                Test = true,
                ReturnUrl = "http://localhost:5445/shopify/chargeresult/?attemptedChargeId=" + Guid.NewGuid().ToString()
            }).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Service.ActivateAsync(Charge.Id.Value).Await();
            Charge = Service.GetAsync(Charge.Id.Value).Await().AsTask.Result;
        };

        [Ignore("Charge tests cannot be run automatically; they require manual confirmation.")]
        It should_activate_a_charge = () =>
        {
            // NOTE: This test will require you to set a break point after creating the charge but before activating it, 
            // grab the confirmation url and manually accept it, then continue the test.
            Charge.Status.ShouldEqual("active");
        };

        Cleanup after = () =>
        {
            //Charges cannot be deleted.
        };

        static ShopifyChargeService Service;

        static Charge Charge;
    }
}
