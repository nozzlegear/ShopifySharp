using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyOrderService))]
    public class When_cancelling_an_order
    {
        Establish context = () =>
        {
            Service = new ShopifyOrderService(Utils.MyShopifyUrl, Utils.AccessToken);
            Id = Service.CreateAsync(OrderCreation.GenerateOrder()).Await().AsTask.Result.Id.Value;
        };

        private Because of = () =>
        {
            Service.CancelAsync(Id).Await();
            Order = Service.GetAsync(Id).Await().AsTask.Result;
        };

        It should_cancel_an_order = () =>
        {
            Order.ShouldNotBeNull();
            Order.Id.ShouldEqual(Id);
            Order.CancelledAt.HasValue.ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Id).Await();
        };

        static ShopifyOrderService Service;

        static Order Order;

        static long Id;
    }
}
