using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;

namespace ShopifySharp.Tests.ShopifyFulfillmentService_Tests
{
    [Subject(typeof(ShopifyFulfillmentService))]
    class When_creating_a_fulfillment
    {
        Establish context = () =>
        {
            Service = new ShopifyFulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = FulfillmentCreation.CreateOrder().Await().AsTask.Result;
        };

        Because of = () =>
        {
            Fulfillment = Service
                .CreateAsync(Order.Id.Value, FulfillmentCreation.GenerateFulfillment(), false)
                .Await()
                .AsTask
                .Result;
        };

        It should_create_a_fulfillment = () =>
        {
            Fulfillment.ShouldNotBeNull();
            Fulfillment.Id.HasValue.ShouldBeTrue();
            Fulfillment.Status.Equals("success", System.StringComparison.OrdinalIgnoreCase).ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            FulfillmentCreation.DeleteOrder(Order.Id.Value).Await();
        };

        static ShopifyFulfillmentService Service;

        static ShopifyFulfillment Fulfillment;

        static Order Order;
    }
}
