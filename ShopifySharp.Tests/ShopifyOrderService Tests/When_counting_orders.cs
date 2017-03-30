using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests
{
    [Subject(typeof(OrderService))]
    public class When_counting_orders
    {
        Establish context = () =>
        {
            Service = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Result = Service.CountAsync().Await().AsTask.Result;
        };

        It should_retrieve_a_count_of_orders = () =>
        {
            Result.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {

        };

        static OrderService Service;

        static int? Result;
    }
}
