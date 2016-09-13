using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyEventService_Tests
{
    [Subject(typeof(ShopifyEventService))]
    class When_listing_events_for_a_subject_type
    {
        Establish context = () =>
        {
            Service = new ShopifyEventService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Events = Service.ListAsync(OrderId, Subject).Await().AsTask.Result;
        };

        It should_list_events_for_a_subject_type = () =>
        {
            Events.ShouldNotBeNull();
            Events.All(e => e.SubjectType.Equals(Subject) && e.SubjectId.Equals(OrderId)).ShouldBeTrue();
        };

        Cleanup after = () =>
        {

        };

        static string Subject = "Order";

        static long OrderId = 3062278019;

        static ShopifyEventService Service;

        static IEnumerable<ShopifyEvent> Events;
    }
}
