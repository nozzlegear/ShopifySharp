using Machine.Specifications;
using ShopifySharp.Filters;
using ShopifySharp.Tests.Test_Data;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyEventService_Tests
{
    [Subject(typeof(ShopifyEventService))]
    class When_getting_an_event
    {
        Establish context = () =>
        {
            Service = new ShopifyEventService(Utils.MyShopifyUrl, Utils.AccessToken);
            var list = Service.ListAsync(new ShopifyEventListFilter()
            {
                Limit = 1
            }).Await().AsTask.Result;           
            Id = list.FirstOrDefault()?.Id;            
        };

        Because of = () =>
        {
            Event = Service.GetAsync(Id.Value).Await().AsTask.Result;            
        };

        It should_get_an_event = () =>
        {
            Event.ShouldNotBeNull();
            Event.Id.ShouldEqual(Id);
            Event.Author.ShouldNotBeNull();
            Event.CreatedAt.HasValue.ShouldBeTrue();
            Event.Message.ShouldNotBeNull();
            Event.Path.ShouldNotBeNull();
            Event.SubjectId.ShouldBeGreaterThan(0);
            Event.SubjectType.ShouldNotBeNull();
            Event.Verb.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {

        };

        static long? Id;

        static ShopifyEventService Service;

        static ShopifyEvent Event;
    }
}
