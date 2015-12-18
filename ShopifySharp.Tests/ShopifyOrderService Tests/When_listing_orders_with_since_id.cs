using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyOrderService))]
    public class When_listing_orders_with_since_id
    {
        Establish context = () =>
        {
            Service = new ShopifyOrderService(Utils.MyShopifyUrl, Utils.AccessToken);

            for (int i = 0; i < 5; i++)
            {
                var order = Service.CreateAsync(OrderCreation.CreateValidOrder()).Await().AsTask.Result;

                CreatedIds.Add(order.Id.Value);
            }

            SinceId = CreatedIds[2];

            Options = new ShopifyOrderFilterOptions()
            {
                SinceId = SinceId
            };            
        };

        Because of = () =>
        {
            Result = Service.ListAsync(Options).Await().AsTask.Result;
        };

        It should_list_orders_greater_than_since_id = () =>
        {
            Result.ShouldNotBeNull();
            Result.All(order => order.Id > SinceId).ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            foreach (var id in CreatedIds)
            {
                Service.DeleteAsync(id).Await();
            }
        };

        static long SinceId;

        static ShopifyOrderService Service;

        static IEnumerable<ShopifyOrder> Result;

        static ShopifyOrderFilterOptions Options;

        static List<long> CreatedIds = new List<long>();
    }
}
