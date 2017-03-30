using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyOrderService))]
    public class When_cancelling_an_order_with_options
    {
        private Establish context = () =>
        {
            var order = OrderCreation.GenerateOrder();

            Service = new ShopifyOrderService(Utils.MyShopifyUrl, Utils.AccessToken);
            Id = Service.CreateAsync(order).Await().AsTask.Result.Id.Value;

            Options = new ShopifyOrderCancelOptions
            {
                Reason = "customer"
            };
        };

        private Because of = () =>
        {
            Service.CancelAsync(Id, Options).Await();
            Order = Service.GetAsync(Id).Await().AsTask.Result;
        };

        private It should_cancel_an_order = () =>
        {
            Order.ShouldNotBeNull();
            Order.Id.ShouldEqual(Id);
            Order.CancelReason.ShouldEqual(Options.Reason);
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Id).Await();
        };

        static ShopifyOrderService Service;

        static Order Order;

        static long Id;

        static ShopifyOrderCancelOptions Options;
    }
}
