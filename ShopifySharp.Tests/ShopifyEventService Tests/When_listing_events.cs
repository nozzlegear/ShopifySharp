using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyEventService_Tests
{
    [Subject(typeof(ShopifyEventService))]
    class When_listing_events
    {
        Establish context = () =>
        {
            Service = new ShopifyEventService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Events = Service.ListAsync().Await().AsTask.Result;
        };
        
        It should_list_events = () =>
        {
            Events.ShouldNotBeNull();
            Events.Count().ShouldBeGreaterThanOrEqualTo(1);
        };

        Cleanup after = () =>
        {

        };

        static ShopifyEventService Service;        

        static IEnumerable<ShopifyEvent> Events;
    }
}
