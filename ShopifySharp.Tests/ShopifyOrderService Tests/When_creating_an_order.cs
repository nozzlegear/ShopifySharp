using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyOrderService))]
    public class When_creating_an_order
    {
        Establish context = () =>
        {
            Service = new ShopifyOrderService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Order = Service.CreateAsync(OrderCreation.CreateValidOrder()).Await().AsTask.Result;
        };

        It should_create_an_order = () =>
        {
            Order.ShouldNotBeNull();
            Order.Id.HasValue.ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            if(Order != null)
            {
                Service.DeleteAsync(Order.Id.Value).Await();
            }
        };

        static ShopifyOrderService Service;

        static ShopifyOrder Order;
    }
}
