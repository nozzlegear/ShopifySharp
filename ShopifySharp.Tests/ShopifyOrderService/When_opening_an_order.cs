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
    public class When_opening_an_order
    {
        Establish context = () =>
        {
            Service = new ShopifyOrderService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = Service.CreateAsync(OrderCreation.CreateValidOrder()).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Service.CloseAsync(Order.Id.Value).Await();
            Service.OpenAsync(Order.Id.Value).Await();
        };

        It should_open_an_order = () =>
        {
            //Update the order from Shopify
            Order = Service.GetAsync(Order.Id.Value).Await().AsTask.Result;

            Order.ClosedAt.HasValue.ShouldBeFalse();
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Order.Id.Value).Await();
        };

        static ShopifyOrderService Service;
        static ShopifyOrder Order;
    }
}
