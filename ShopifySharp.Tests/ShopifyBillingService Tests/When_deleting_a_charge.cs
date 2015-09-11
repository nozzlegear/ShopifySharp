using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyBillingService_Tests
{
    [Subject(typeof(ShopifyBillingService))]
    class When_deleting_a_charge
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
            try
            {
                Service.DeleteAsync(ChargeId).Await();
            }
            catch (Exception e)
            {
                Exception = e;
            }
        };

        It should_delete_a_charge = () =>
        {
            Exception.ShouldBeNull();
        };

        Cleanup after = () =>
        {

        };

        static ShopifyBillingService Service;

        static Exception Exception;

        static long ChargeId;
    }
}
