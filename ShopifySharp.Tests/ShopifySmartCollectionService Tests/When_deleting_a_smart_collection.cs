using Machine.Specifications;
using System;

namespace ShopifySharp.Tests.ShopifySmartCollectionService_Tests
{
    [Subject(typeof(ShopifySmartCollectionService))]
    class When_deleting_a_smart_collection
    {
        Establish context = () =>
        {
            CollectionId = Service.CreateAsync(SmartCollectionUtils.CreateCollection()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
            Ex = Catch.Exception(() => Service.DeleteAsync(CollectionId.Value).Await());
        };

        It should_delete_a_smart_collection = () =>
        {
            Ex.ShouldBeNull();
        };

        Cleanup after = () =>
        {
            
        };

        static ShopifySmartCollectionService Service = new ShopifySmartCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);

        static long? CollectionId;

        static Exception Ex;
    }
}
