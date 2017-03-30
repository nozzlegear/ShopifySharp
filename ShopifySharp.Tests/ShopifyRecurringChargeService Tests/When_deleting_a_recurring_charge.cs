using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyRecurringChargeService_Tests
{
    [Subject(typeof(ShopifyRecurringChargeService))]
    class When_deleting_a_recurring_charge
    {
        Establish context = () =>
        {
            // NOTE: Creating a charge will fail if the access token used is for a private app. 
            // Only real apps can use the Shopify billing API.

            Service = new ShopifyRecurringChargeService(Utils.BillingMyShopifyUrl, Utils.BillingAccessToken);
            Charge = Service.CreateAsync(new RecurringCharge()
            {
                Name = "Lorem Ipsum Plan",
                Price = 123.45,
                Test = true,
            }).Await().AsTask.Result;
        };

        Because of = () =>
        {
            try
            {
                Service.ActivateAsync(Charge.Id.Value).Await();
                Service.DeleteAsync(Charge.Id.Value).Await();
            }
            catch (Exception e)
            {
                Exception = e;
            }
        };

        [Ignore("Charge tests cannot be run automatically; they require manual confirmation.")]
        It should_delete_a_recurring_charge = () =>
        {
            // A charge cannot be deleted unless it has been activated. This test will fail unless you manually 
            // accept the charge, then activate it, then let the test delete it.

            Exception.ShouldBeNull();
        };

        Cleanup after = () =>
        {

        };

        static ShopifyRecurringChargeService Service;

        static Exception Exception;

        static RecurringCharge Charge;
    }
}
