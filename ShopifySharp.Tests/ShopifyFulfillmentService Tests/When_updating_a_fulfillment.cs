using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyFulfillmentService_Tests
{
    [Subject(typeof(ShopifyFulfillmentService))]
    class When_updating_a_fulfillment
    {
        Establish context = () =>
        {
            Service = new ShopifyFulfillmentService(Utils.MyShopifyUrl, Utils.AccessToken);
            Order = FulfillmentCreation.CreateOrder().Await().AsTask.Result;

            var fulfillment = FulfillmentCreation.GenerateFulfillment();

            Created = Service
                .CreateAsync(Order.Id.Value, fulfillment, false)
                .Await()
                .AsTask
                .Result;

            Created.TrackingCompany = "John Doe's Shipping Company";
        };

        Because of = () =>
        {
            Fulfillment = Service.UpdateAsync(Order.Id.Value, Created).Await().AsTask.Result;
        };

        It should_update_a_fulfillment = () =>
        {
            Fulfillment.ShouldNotBeNull();
            Fulfillment.Id.HasValue.ShouldBeTrue();
            Fulfillment.TrackingCompany.ShouldEqual(Created.TrackingCompany);
        };

        Cleanup after = () =>
        {
            FulfillmentCreation.DeleteOrder(Order.Id.Value).Await();
        };

        static ShopifyFulfillmentService Service;

        static ShopifyFulfillment Fulfillment;

        static ShopifyFulfillment Created;

        static Order Order;
    }
}
