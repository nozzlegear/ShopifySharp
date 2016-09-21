using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyFulfillmentService_Tests
{
    [Subject(typeof(ShopifyFulfillmentService))]
    class When_completing_a_fulfillment
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
            Fulfillment = Service.CompleteAsync(Order.Id.Value, Id).Await();
        };

        [Ignore("This test is failing because you can't complete or cancel a fulfillment that's status is not 'pending'. It's not clear how to create a fulfillment that's pending, though.")]
        It should_complete_a_fulfillment = () =>
        {
            Fulfillment.ShouldNotBeNull();
            Fulfillment.Id.HasValue.ShouldBeTrue();
            Fulfillment.Status.ShouldEqual("success");
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
