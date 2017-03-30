using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyFulfillmentService_Tests
{
    [Subject(typeof(ShopifyFulfillmentService))]
    class When_counting_fulfillments
    {
        Establish context = () =>
        {
            Service = new ShopifyFulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = FulfillmentCreation.CreateOrder().Await().AsTask.Result;

            for (var i = 0; i < 2; i++)
            {
                var items = Order.LineItems.Skip(i).Take(1);
                var fulfillment = FulfillmentCreation.GenerateFulfillment(items: items);

                Service.CreateAsync(Order.Id.Value, fulfillment, false).Await();
            }
        };

        Because of = () =>
        {
            Result = Service.CountAsync(Order.Id.Value).Await().AsTask.Result;
        };

        It should_count_fulfillments = () =>
        {
            Result.ShouldBeGreaterThanOrEqualTo(2);
        };

        Cleanup after = () =>
        {
            FulfillmentCreation.DeleteOrder(Order.Id.Value).Await();
        };

        static ShopifyFulfillmentService Service;

        static int Result;

        static Order Order;
    }
}
