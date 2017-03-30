using Machine.Specifications;
using System;

namespace ShopifySharp.Tests.ShopifyCustomCollectionService_Tests
{
    [Subject(typeof(CustomCollectionService))]
    public class When_publishing_a_custom_collection
    {
        Establish context = () =>
        {
            Service = new CustomCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);
            Collection = Service.CreateAsync(SubjectUtils.CreateValidObject()).Await().AsTask.Result;

            Collection.PublishedAt = DateTime.UtcNow;
        };

        Because of = () =>
        {
            Collection = Service.UpdateAsync(Collection).Await().AsTask.Result;
        };

        It should_publish_a_custom_collection = () =>
        {
            Collection.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Collection.Id.Value).Await();
        };

        static CustomCollectionService Service;

        static CustomCollection Collection;
    }
}
