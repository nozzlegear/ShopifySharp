using Machine.Specifications;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Tests.ShopifySmartCollectionService_Tests
{
    [Subject(typeof(SmartCollectionService))]
    class When_listing_a_smart_collection
    {
        Establish context = () =>
        {
            CreatedId = Service.CreateAsync(SmartCollectionUtils.CreateCollection()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
            Collections = Service.ListAsync().Await().AsTask.Result;
        };

        It should_create_a_smart_collection = () =>
        {
            Collections.ShouldNotBeNull();
            Collections.Count().ShouldBeGreaterThanOrEqualTo(1);
            Collections.Any(collection =>
            {
                collection.Id.HasValue.ShouldBeTrue();
                collection.BodyHtml.ShouldEqual(SmartCollectionUtils.BodyHtml);
                collection.Handle.ShouldBeEqualIgnoringCase(SmartCollectionUtils.Handle);
                collection.Title.ShouldEqual(SmartCollectionUtils.Title);

                // .Should checks will throw an exception if false
                return true;
            }).ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            if (CreatedId.HasValue)
            {
                Service.DeleteAsync(CreatedId.Value).Await();
            }
        };

        static SmartCollectionService Service = new SmartCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);

        static IEnumerable<SmartCollection> Collections;

        static long? CreatedId;
    }
}
