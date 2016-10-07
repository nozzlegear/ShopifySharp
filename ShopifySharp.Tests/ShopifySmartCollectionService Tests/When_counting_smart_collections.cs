using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifySmartCollectionService_Tests
{
    [Subject(typeof(ShopifySmartCollectionService))]
    class When_counting_smart_collections
    {
        Establish context = () =>
        {

        };

        Because of = () =>
        {
            Count = Service.CountAsync().Await();
        };

        It should_count_smart_collections = () =>
        {
            Count.HasValue.ShouldBeTrue();
        };

        Cleanup after = () =>
        {

        };

        static ShopifySmartCollectionService Service = new ShopifySmartCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);

        static int? Count;
    }
}
