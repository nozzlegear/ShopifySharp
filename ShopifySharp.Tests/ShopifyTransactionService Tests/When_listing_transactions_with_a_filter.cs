using Machine.Specifications;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyTransactionService_Tests
{
    [Subject(typeof(ShopifyTransactionService))]
    class When_listing_transactions_with_a_filter
    {
        Establish context = () =>
        {
            Service = new ShopifyTransactionService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = Setup.CreateOrder().Await().AsTask.Result;

            for (var i = 0; i < 2; i++)
            {
               var transaction = Service
                    .CreateAsync(Order.Id.Value, Setup.GenerateTransaction("capture", 5.00))
                    .Await()
                    .AsTask
                    .Result;

                if(i == 0)
                {
                    SinceId = transaction.Id.Value;
                }
            }
        };

        Because of = () =>
        {
            Result = Service
                .ListAsync(Order.Id.Value, SinceId)
                .Await()
                .AsTask
                .Result;
        };

        It should_list_transactions_with_a_filter = () =>
        {
            Result.Count().ShouldEqual(1);
        };

        Cleanup after = () =>
        {
            Setup.DeleteOrder(Order.Id.Value).Await();
        };

        static ShopifyTransactionService Service;

        static Order Order;

        static IEnumerable<Transaction> Result;

        static long SinceId;
    }
}
