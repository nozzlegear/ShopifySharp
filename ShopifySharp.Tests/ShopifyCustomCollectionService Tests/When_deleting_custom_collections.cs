using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyCustomCollectionService_Tests
{
    [Subject(typeof(ShopifyCustomCollectionService))]
    public class When_deleting_a_custom_collection
    {
        Establish context = () =>
        {
            Service = new ShopifyCustomCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);
            Collection = Service.CreateAsync(SubjectUtils.CreateValidObject()).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Service.DeleteAsync(Collection.Id.Value).Await();
        };

        It should_delete_a_custom_collection = () =>
        {
            //Passes if no exception was thrown.
        };

        Cleanup after = () =>
        {
            
        };

        static ShopifyCustomCollectionService Service;

        static CustomCollection Collection;
    }
}
