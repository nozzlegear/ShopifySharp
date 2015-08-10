using Machine.Specifications;
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

            // TODO: Create three orders
            for(int i = 0; i < 3; i++)
            {

            }
        };

        Because of = () =>
        {
            Result = Service.ListAsync(Options).Await().AsTask.Result;
        };

        It should_only_list_2_orders = () =>
        {
            Result.ShouldNotBeNull();
            Result.Count().Equals(2).ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            // TODO: Delete orders
        };

        static ShopifyOrderService Service;

        static IEnumerable<ShopifyOrder> Result;

        static ShopifyOrderFilterOptions Options = new ShopifyOrderFilterOptions()
        {
            Limit = 2
        };

        static List<long> CreatedIds = new List<long>();
    }
}
