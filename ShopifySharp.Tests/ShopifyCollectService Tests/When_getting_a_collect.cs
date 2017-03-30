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
    class When_getting_a_collect
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
            Collect = Service.GetAsync(Id).Await().AsTask.Result;
        };

        It should_get_a_collect = () =>
        {
            Collect.ShouldNotBeNull();
            Collect.Id.Value.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Id).Await();
            CollectCreation.DeleteProduct(Product.Id.Value).Await();
        };

        static ShopifyCollectService Service;

        static Collect Collect;

        static long Id;

        static ShopifySharp.Product Product;
    }
}
