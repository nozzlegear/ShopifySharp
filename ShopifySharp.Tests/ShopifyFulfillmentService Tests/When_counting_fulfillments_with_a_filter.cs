using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ShopifySharp.Tests.ShopifyFulfillmentService_Tests
{
    [Subject(typeof(ShopifyFulfillmentService))]
    class When_counting_fulfillments_with_a_filter
    {
        Establish context = () =>
        {
            Service = new ShopifyFulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = FulfillmentCreation.CreateOrder().Await().AsTask.Result;

            for (var i = 0; i < 2; i++)
            {
                var items = Order.LineItems.Skip(i).Take(1);
                var fulfillment = FulfillmentCreation.GenerateFulfillment(items: items);

                Created.Add(Service.CreateAsync(Order.Id.Value, fulfillment, true).Await().AsTask.Result);

                //Wait 1 second so created fulfillments have differing times.
                Thread.Sleep(1000);
            }
        };

        Because of = () =>
        {
            Result = Service.CountAsync(Order.Id.Value, new ShopifyCountFilter()
            {
                CreatedAtMin = Created.Last().CreatedAt
            }).Await().AsTask.Result;
        };

        It should_count_fulfillments_with_a_filter = () =>
        {
            Result.ShouldEqual(1);
        };

        Cleanup after = () =>
        {
            FulfillmentCreation.DeleteOrder(Order.Id.Value).Await();
        };

        static ShopifyFulfillmentService Service;

        static int Result;

        static List<ShopifyFulfillment> Created = new List<ShopifyFulfillment>();

        static ShopifyOrder Order;
    }
}
