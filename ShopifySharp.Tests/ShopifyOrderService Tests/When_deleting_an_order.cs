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
    public class When_deleting_an_order
    {
        Establish context = () =>
        {
            Service = new ShopifyOrderService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = Service.CreateAsync(OrderCreation.GenerateOrder()).Await().AsTask.Result;
        };

        Because of = () =>
        {
            try
            {
                Service.DeleteAsync(Order.Id.Value).Await();
            }
            catch(ShopifyException e)
            {
                Exception = e;
            }
        };

        It should_delete_an_order = () =>
        {
            Exception.ShouldBeNull();
        };

        Cleanup after = () =>
        {

        };

        static ShopifyOrderService Service;
        static ShopifyOrder Order;
        static ShopifyException Exception;
    }
}
