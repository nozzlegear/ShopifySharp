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
    class When_creating_a_partial_transaction_capture
    {
        Establish context = () =>
        {
            Service = new ShopifyTransactionService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = Setup.CreateOrder().Await().AsTask.Result;
        };

        Because of = () =>
        {
            Transaction = Service
                .CreateAsync(Order.Id.Value, Setup.GenerateTransaction("capture", 5.00))
                .Await()
                .AsTask
                .Result;
        };

        It should_create_a_partial_transaction_capture = () =>
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

        static Order Order;

        static Transaction Transaction;
    }
}
