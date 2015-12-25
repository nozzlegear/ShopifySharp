using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyFulfillmentService_Tests
{
    [Subject(typeof(ShopifyFulfillmentService))]
    class When_cancelling_a_fulfillment
    {
        Establish context = () =>
        {
            Service = new ShopifyFulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = FulfillmentCreation.CreateOrder().Await().AsTask.Result;

            var fulfillment = FulfillmentCreation.GenerateFulfillment();

            Id = Service
                .CreateAsync(Order.Id.Value, fulfillment, true)
                .Await()
                .AsTask
                .Result
                .Id
                .Value;
        };

        Because of = () =>
        {
            Fulfillment = Service.CancelAsync(Order.Id.Value, Id).Await();
        };

        [Ignore("This test is failing because you can't complete or cancel a fulfillment that's status is not 'pending'. It's not clear how to create a fulfillment that's pending, though.")]
        It should_cancel_a_fulfillment = () =>
        {
            Fulfillment.ShouldNotBeNull();
            Fulfillment.Id.HasValue.ShouldBeTrue();
            Fulfillment.Status.ShouldEqual("cancelled");
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
