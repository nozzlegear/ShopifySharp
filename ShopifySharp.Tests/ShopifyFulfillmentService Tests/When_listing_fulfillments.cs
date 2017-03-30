using Machine.Specifications;
using ShopifySharp.Filters;
using ShopifySharp.Tests.Test_Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ShopifySharp.Tests.ShopifyFulfillmentService_Tests
{
    [Subject(typeof(ShopifyFulfillmentService))]
    class When_listing_fulfillments
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
            Result = Service.ListAsync(Order.Id.Value, new ShopifyListFilter()).Await().AsTask.Result;
        };

        It should_list_fulfillments = () =>
        {
            Result.ShouldNotBeNull();
            Result.Count().ShouldEqual(2);
        };

        Cleanup after = () =>
        {
            FulfillmentCreation.DeleteOrder(Order.Id.Value).Await();
        };

        static ShopifyFulfillmentService Service;

        static IEnumerable<ShopifyFulfillment> Result;

        static Order Order;
    }
}
