using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyOrderService)), Tags("Order")]
    public class When_listing_orders
    {
        Establish context = () =>
        {
            Service = new ShopifyOrderService(Utils.MyShopifyUrl, Utils.AccessToken);
            CreatedOrders = new List<ShopifyOrder>();
            
            //Ensure there are some orders to list.
            for (int i = 0; i < 3; i++)
            {
                var order = OrderCreation.GenerateOrder();

                order = Service.CreateAsync(order).Await().AsTask.Result;

                CreatedOrders.Add(order);
            }
        };

        Because of = () =>
        {
            Result = Service.ListAsync().Await().AsTask.Result;
        };

        It should_list_orders = () =>
        {
            Result.ShouldNotBeNull();
            Result.Count().ShouldBeGreaterThanOrEqualTo(2);
        };

        Cleanup after = () =>
        {
            foreach(var order in CreatedOrders)
            {
                Service.DeleteAsync(order.Id.Value).Await();
            }
        };

        static ShopifyOrderService Service;

        static IEnumerable<ShopifyOrder> Result;

        static List<ShopifyOrder> CreatedOrders;

        static List<long> CreatedIds = new List<long>();
    }
}
