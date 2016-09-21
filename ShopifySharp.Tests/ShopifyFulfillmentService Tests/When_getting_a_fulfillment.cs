using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyFulfillmentService_Tests
{
    [Subject(typeof(ShopifyFulfillmentService))]
    class When_getting_a_fulfillment
    {
        Establish context = () =>
        {
            Service = new ShopifyFulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = FulfillmentCreation.CreateOrder().Await().AsTask.Result;

            var fulfillment = FulfillmentCreation.GenerateFulfillment();

            Id = Service
                .CreateAsync(Order.Id.Value, fulfillment, false)
                .Await()
                .AsTask
                .Result
                .Id
                .Value;
        };

        Because of = () =>
        {
            Fulfillment = Service.GetAsync(Order.Id.Value, Id).Await().AsTask.Result;
        };

        It should_get_a_fulfillment = () =>
        {
            Fulfillment.ShouldNotBeNull();
            Fulfillment.Id.HasValue.ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            FulfillmentCreation.DeleteOrder(Order.Id.Value).Await();
        };

        static ShopifyFulfillmentService Service;

        static ShopifyFulfillment Fulfillment;

        static long Id;

        static ShopifyOrder Order;
    }
}
