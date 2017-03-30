using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifySmartCollectionService_Tests
{
    [Subject(typeof(ShopifySmartCollectionService))]
    class When_updating_a_smart_collection
    {
        Establish context = () =>
        {
            Collection = Service.CreateAsync(SmartCollectionUtils.CreateCollection()).Await();
        };

        Because of = () =>
        {
            Collection.BodyHtml = UpdatedHtml;
            Collection = Service.UpdateAsync(Collection).Await();
        };

        It should_update_a_smart_collection = () =>
        {
            Collection.ShouldNotBeNull();
            Collection.Id.HasValue.ShouldBeTrue();
            Collection.BodyHtml.ShouldEqual(UpdatedHtml);
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

        static string UpdatedHtml = "<h2>Updated collection HTML</h2>";

        static ShopifySmartCollectionService Service = new ShopifySmartCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);

        static SmartCollection Collection;
    }
}
