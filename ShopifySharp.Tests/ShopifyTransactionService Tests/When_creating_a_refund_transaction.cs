using Machine.Specifications;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyTransactionService_Tests
{
    [Subject(typeof(TransactionService))]
    class When_creating_a_refund_transaction
    {
        Establish context = () =>
        {
            Service = new TransactionService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = Setup.CreateOrder().Await().AsTask.Result;
        };

        Because of = () =>
        {
            Transaction = Service
                .CreateAsync(Order.Id.Value, Setup.GenerateTransaction("refund"))
                .Await()
                .AsTask
                .Result;
        };

        [Ignore("This test returns the error 'Order cannot be refunded'. Orders that were created via API, not using a Shopify transaction gateway, cannot be refunded. Therefore, refunds are untestable.")]
        It should_create_a_refund_transaction = () =>
        {
            Transaction.ShouldNotBeNull();
            Transaction.Status.ShouldEqual("success");
            Transaction.ErrorCode.ShouldBeNull();
            Transaction.Kind.ShouldEqual("refund");
        };

        Cleanup after = () =>
        {
            Setup.DeleteOrder(Order.Id.Value).Await();
        };

        static TransactionService Service;

        static Order Order;

        static Transaction Transaction;
    }
}
