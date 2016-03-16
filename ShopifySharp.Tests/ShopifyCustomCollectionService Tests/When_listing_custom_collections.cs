using Machine.Specifications;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyCustomCollectionService_Tests
{
    [Subject(typeof(ShopifyCustomCollectionService))]
    public class When_listing_a_custom_collection
    {
        Establish context = () =>
        {
            Service = new ShopifyCustomCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);

            for (int i = 0; i < 3; i++)
            {
                CreatedCollections.Add(Service.CreateAsync(SubjectUtils.CreateValidObject()).Await().AsTask.Result);
            }
        };

        Because of = () =>
        {
            Collections = Service.ListAsync().Await().AsTask.Result;
        };

        It should_list_custom_collections = () =>
        {
            Collections.ShouldNotBeNull();
            Collections.Count().ShouldBeGreaterThanOrEqualTo(3);
        };

        Cleanup after = () =>
        {
            foreach (var collection in CreatedCollections)
            {
                Service.DeleteAsync(collection.Id.Value).Await();
            }
        };

        static ShopifyCustomCollectionService Service;
        
        static IEnumerable<ShopifyCustomCollection> Collections;

        static List<ShopifyCustomCollection> CreatedCollections = new List<ShopifyCustomCollection>();
    }
}
