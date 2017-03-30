using Machine.Specifications;
using ShopifySharp.Enums;

namespace ShopifySharp.Tests.ShopifyTransactionService_Tests
{
    [Subject(typeof(TransactionService))]
    class When_creating_a_transaction
    {
        Establish context = () =>
        {
            Service = new TransactionService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = Setup.CreateOrder().Await().AsTask.Result;
        };

        Because of = () =>
        {
            Transaction = Service
                .CreateAsync(Order.Id.Value, Setup.GenerateTransaction("capture"))
                .Await()
                .AsTask
                .Result;
        };

        It should_create_a_transaction = () =>
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

        static TransactionService Service;

        static Order Order;

        static Transaction Transaction;
    }
}
