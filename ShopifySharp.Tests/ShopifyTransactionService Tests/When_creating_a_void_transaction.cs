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
    class When_creating_a_void_transaction
    {
        Establish context = () =>
        {
            Service = new ShopifyTransactionService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = Setup.CreateOrder().Await().AsTask.Result;
        };

        Because of = () =>
        {
            Transaction = Service
                .CreateAsync(Order.Id.Value, Setup.GenerateTransaction("void"))
                .Await()
                .AsTask
                .Result;
        };

        [Ignore("Attempting to create a transaction with its kind set to 'void' causes Shopify to throw a 500 Internal Server Error. Like the 'refund' kind, it's probably impossible to cancel a transaction when the order was created via API without going through a legit payment gateway.")]
        It should_create_a_void_transaction = () =>
        {
            Transaction.ShouldNotBeNull();
            Transaction.Status.ShouldEqual("success");
            Transaction.ErrorCode.ShouldBeNull();
            Transaction.Kind.ShouldEqual("void");
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
