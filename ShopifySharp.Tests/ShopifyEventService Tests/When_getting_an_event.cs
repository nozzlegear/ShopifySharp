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
           
            if (list != null)
            {
                Id = list.FirstOrDefault()?.Id;
            }
        };

        Because of = () =>
        {
            if (Id.HasValue)
            {
                Event = Service.GetAsync(Id.Value).Await().AsTask.Result;
            }
        };

        It should_get_an_event = () =>
        {
            if (Id.HasValue)
            {
                Event.ShouldNotBeNull();
                Event.Id.ShouldEqual(Id);
            }
        };

        Cleanup after = () =>
        {

        };

        static long? Id;

        static ShopifyEventService Service;

        static ShopifyEvent Event;
    }
}
