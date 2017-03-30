using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;

namespace ShopifySharp.Tests.ShopifyEventService_Tests
{
    [Subject(typeof(EventService))]
    class When_counting_events
    {
        Establish context = () =>
        {
            Service = new EventService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Count = Service.CountAsync().Await().AsTask.Result;
        };

        It should_count_events = () =>
        {
            Count.ShouldBeGreaterThanOrEqualTo(1);
        };

        Cleanup after = () =>
        {

        };

        static EventService Service;        

        static int Count;
    }
}
