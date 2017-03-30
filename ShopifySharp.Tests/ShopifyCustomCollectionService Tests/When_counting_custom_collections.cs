using Machine.Specifications;
using System;
using System.Collections.Generic;

namespace ShopifySharp.Tests.ShopifyCustomCollectionService_Tests
{
    [Subject(typeof(CustomCollectionService))]
    public class When_counting_a_custom_collection
    {
        Establish context = () =>
        {
            Service = new CustomCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);

            for(int i = 0; i < 3; i ++)
            {
                CreatedCollections.Add(Service.CreateAsync(SubjectUtils.CreateValidObject()).Await().AsTask.Result);
            }
        };

        Because of = () =>
        {
            Count = Service.CountAsync().Await().AsTask.Result;
        };

        It should_count_custom_collections = () =>
        {
            Count.ShouldNotBeNull();
            Count.ShouldBeGreaterThanOrEqualTo(3);
        };

        Cleanup after = () =>
        {
            foreach(var collection in CreatedCollections)
            {
                Service.DeleteAsync(collection.Id.Value).Await();
            }
        };

        static CustomCollectionService Service;

        static int Count;

        static List<CustomCollection> CreatedCollections = new List<CustomCollection>();
    }
}
