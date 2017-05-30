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
    public class When_updating_an_order
    {
        Establish context = () =>
        {
            Service = new ShopifyOrderService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = Service.CreateAsync(OrderCreation.GenerateOrder()).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Order.Note = "Test notes";
            Service.UpdateAsync(Order).Await();
        };

        It should_update_an_order = () =>
        {
            //Update the order from Shopify
            Order = Service.GetAsync(Order.Id.Value).Await().AsTask.Result;

            Order.Note.Equals("Test notes").ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Order.Id.Value).Await();
        };

        static ShopifyOrderService Service;
        static ShopifyOrder Order;
    }
}
