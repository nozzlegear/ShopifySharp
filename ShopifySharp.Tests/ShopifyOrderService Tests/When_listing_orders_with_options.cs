using Machine.Specifications;
using ShopifySharp.Filters;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyOrderService))]
    public class When_listing_orders_with_options
    {
        Establish context = () =>
        {
            Service = new ShopifyOrderService(Utils.MyShopifyUrl, Utils.AccessToken);

            for (int i = 0; i < 3; i++)
            {
                var order = Service.CreateAsync(OrderCreation.GenerateOrder()).Await().AsTask.Result;

                CreatedIds.Add(order.Id.Value);
            }

            Options = new OrderFilter()
            {
                Ids = CreatedIds
            };
        };

        Because of = () =>
        {
            Result = Service.ListAsync(Options).Await().AsTask.Result;
        };

        It should_list_orders_with_specific_ids = () =>
        {
            Result.ShouldNotBeNull();
            Result.All(order => CreatedIds.Contains(order.Id.Value));
            Result.Count().ShouldEqual(CreatedIds.Count);
        };

        Cleanup after = () =>
        {
            foreach (var id in CreatedIds)
            {
                Service.DeleteAsync(id).Await();
            }
        };

        static ShopifyOrderService Service;

        static IEnumerable<Order> Result;

        static OrderFilter Options;

        static List<long> CreatedIds = new List<long>();
    }
}
