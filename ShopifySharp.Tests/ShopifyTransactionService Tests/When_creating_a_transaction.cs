using Machine.Specifications;
using ShopifySharp.Enums;

namespace ShopifySharp.Tests.ShopifyTransactionService_Tests
{
    [Subject(typeof(ShopifyTransactionService))]
    class When_creating_a_transaction
    {
        Establish context = () =>
        {
            Service = new ShopifyTransactionService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = Setup.CreateOrder().Await().AsTask.Result;
        };

        Because of = () =>
        {
            Transaction = Service
                .CreateAsync(Order.Id.Value, Setup.GenerateTransaction(ShopifyTransactionKind.Capture))
                .Await()
                .AsTask
                .Result;
        };

        It should_create_a_transaction = () =>
        {
            Transaction.ShouldNotBeNull();
            Transaction.Status.ShouldEqual("success");
            Transaction.ErrorCode.ShouldBeNull();
            Transaction.Kind.ShouldEqual(ShopifyTransactionKind.Capture);
        };

        Cleanup after = () =>
        {
            Setup.DeleteOrder(Order.Id.Value).Await();
        };

        static ShopifyTransactionService Service;

        static ShopifyOrder Order;

        static ShopifyTransaction Transaction;
    }
}
