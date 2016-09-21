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
    class When_gettng_a_transaction
    {
        Establish context = () =>
        {
            Service = new ShopifyTransactionService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = Setup.CreateOrder().Await().AsTask.Result;
            Id = Service
                    .CreateAsync(Order.Id.Value, Setup.GenerateTransaction("capture"))
                    .Await()
                    .AsTask
                    .Result
                    .Id
                    .Value;
        };

        Because of = () =>
        {
            Transaction = Service
                .GetAsync(Order.Id.Value, Id)
                .Await()
                .AsTask
                .Result;
        };

        It should_get_a_transaction = () =>
        {
            Transaction.ShouldNotBeNull();
            Transaction.Status.ShouldEqual("success");
            Transaction.ErrorCode.ShouldBeNull();
            Transaction.Kind.ShouldEqual("capture");
        };

        Cleanup after = () =>
        {
            Setup.DeleteOrder(Order.Id.Value).Await();
        };

        static ShopifyTransactionService Service;

        static ShopifyOrder Order;

        static ShopifyTransaction Transaction;

        static long Id;
    }
}
