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
    class When_counting_collects
    {
        Establish context = () =>
        {
            Service = new ShopifyCollectService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = CollectCreation.CreateProduct().Await().AsTask.Result;

            Id = Service.CreateAsync(new Collect()
            {
                CollectionId = CollectCreation.CollectionId,
                ProductId = Product.Id.Value
            }).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            Count = Service.CountAsync().Await().AsTask.Result;
        };

        It should_count_collects = () =>
        {
            Count.ShouldBeGreaterThanOrEqualTo(1);
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Id).Await();
            CollectCreation.DeleteProduct(Product.Id.Value).Await();
        };

        static ShopifyCollectService Service;        

        static long Id;

        static int Count;

        static ShopifySharp.Product Product;
    }
}
