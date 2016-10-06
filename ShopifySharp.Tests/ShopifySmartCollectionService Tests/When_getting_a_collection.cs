using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifySmartCollectionService_Tests
{
    [Subject(typeof(ShopifySmartCollectionService))]
    class When_getting_a_smart_collection
    {
        Establish context = () =>
        {
            CollectionId = Service.CreateAsync(SmartCollectionUtils.CreateCollection()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
            Collection = Service.GetAsync(CollectionId.Value).Await();
        };

        It should_get_a_smart_collection = () =>
        {
            Collection.ShouldNotBeNull();
            Collection.Id.HasValue.ShouldBeTrue();
            Collection.BodyHtml.ShouldEqual(SmartCollectionUtils.BodyHtml);
            Collection.Handle.ShouldBeEqualIgnoringCase(SmartCollectionUtils.Handle);
            Collection.Title.ShouldEqual(SmartCollectionUtils.Title);
        };

        Cleanup after = () =>
        {
            if (Collection != null && Collection.Id.HasValue)
            {
                Service.DeleteAsync(Collection.Id.Value).Await();
            }
        };

        static ShopifySmartCollectionService Service = new ShopifySmartCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);

        static ShopifySmartCollection Collection;

        static long? CollectionId;
    }
}
