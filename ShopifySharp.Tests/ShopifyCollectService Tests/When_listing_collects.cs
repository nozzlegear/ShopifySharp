using Machine.Specifications;
using ShopifySharp.Tests.ShopifyCollectService_Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyCollectService_Tests
{
    [Subject(typeof(ShopifyCollectService))]
    class When_listing_collects
    {
        Establish context = () =>
        {
            Service = new ShopifyCollectService(Utils.MyShopifyUrl, Utils.AccessToken);


            for (var i = 0; i < 3; i++)
            {
                var product = CollectCreation.CreateProduct().Await().AsTask.Result;
                var collect = Service.CreateAsync(new ShopifyCollect()
                {
                    CollectionId = CollectCreation.CollectionId,
                    ProductId = product.Id.Value
                }).Await().AsTask.Result;

                Products.Add(product);
                Created.Add(collect);
            }
        };

        Because of = () =>
        {
            Result = Service.ListAsync().Await().AsTask.Result;
        };

        It should_list_collects = () =>
        {
            Result.ShouldNotBeNull();
            Result.Count().ShouldBeGreaterThanOrEqualTo(3);
        };

        Cleanup after = () =>
        {
            foreach (var collect in Created)
            {
                Service.DeleteAsync(collect.Id.Value).Await();
            }

            foreach (var product in Products)
            {
                CollectCreation.DeleteProduct(product.Id.Value).Await();
            }
        };

        static ShopifyCollectService Service;

        static List<ShopifyCollect> Created = new List<ShopifyCollect>();

        static List<ShopifyProduct> Products = new List<ShopifyProduct>();

        static IEnumerable<ShopifyCollect> Result;
    }
}
