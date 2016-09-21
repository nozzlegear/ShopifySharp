using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyFulfillmentService_Tests
{
    [Subject(typeof(ShopifyFulfillmentService))]
    class When_creating_a_partial_fulfillment
    {
        Establish context = () =>
        {
            Service = new ShopifyFulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = FulfillmentCreation.CreateOrder().Await().AsTask.Result;
        };

        Because of = () =>
        {
            //A partial fulfillment does not fulfill the entire line item quantity
            var lineItem = Order.LineItems.First();
            lineItem.Quantity -= 1;

            var fulfillment = FulfillmentCreation.GenerateFulfillment(false, Order.LineItems.Take(1));

            Fulfillment = Service
                .CreateAsync(Order.Id.Value, fulfillment, false)
                .Await()
                .AsTask
                .Result;
        };

        It should_create_a_single_fulfillment = () =>
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

        static ShopifyOrder Order;
    }
}
