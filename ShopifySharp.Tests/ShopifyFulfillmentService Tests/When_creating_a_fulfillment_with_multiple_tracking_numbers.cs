using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyFulfillmentService_Tests
{
    [Subject(typeof(ShopifyFulfillmentService))]
    class When_creating_a_fulfillment_with_multiple_tracking_numbers
    {
        Establish context = () =>
        {
            Service = new ShopifyFulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = FulfillmentCreation.CreateOrder().Await().AsTask.Result;
        };

        Because of = () =>
        {
            var fulfillment = FulfillmentCreation.GenerateFulfillment(true);

            Fulfillment = Service
                .CreateAsync(Order.Id.Value, fulfillment, false)
                .Await()
                .AsTask
                .Result;
        };

        It should_create_a_fulfillment_with_multiple_tracking_numbers = () =>
        {
            Fulfillment.ShouldNotBeNull();
            Fulfillment.Id.HasValue.ShouldBeTrue();
            Fulfillment.Status.Equals("success", System.StringComparison.OrdinalIgnoreCase).ShouldBeTrue();

            Fulfillment.TrackingNumbers.Count().ShouldBeGreaterThan(1);
        };

        Cleanup after = () =>
        {
            FulfillmentCreation.DeleteOrder(Order.Id.Value).Await();
        };

        static ShopifyFulfillmentService Service;

        static ShopifyFulfillment Fulfillment;

        static ShopifyOrder Order;
    }
}
