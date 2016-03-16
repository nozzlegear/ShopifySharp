using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyCustomCollectionService_Tests
{
    [Subject(typeof(ShopifyCustomCollectionService))]
    public class When_creating_a_custom_collection
    {
        Establish context = () =>
        {
            Service = new ShopifyCustomCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Collection = Service.CreateAsync(SubjectUtils.CreateValidObject()).Await().AsTask.Result;
        };

        It should_create_a_custom_collection = () =>
        {
            Collection.ShouldNotBeNull();
            Collection.Id.HasValue.ShouldBeTrue();
            Collection.Image.ShouldNotBeNull();
            Collection.Image.Src.ShouldNotBeNull();
            Collection.Title.ShouldEqual("Things");
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Collection.Id.Value).Await();
        };

        static ShopifyCustomCollectionService Service;

        static ShopifyCustomCollection Collection;
    }
}
