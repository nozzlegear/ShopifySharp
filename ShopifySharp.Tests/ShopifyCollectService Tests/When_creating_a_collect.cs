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
    class When_creating_a_collect
    {
        Establish context = () =>
        {
            Service = new ShopifyCollectService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = CollectCreation.CreateProduct().Await().AsTask.Result;
        };

        Because of = () =>
        {
            Collect = Service.CreateAsync(new Collect()
            {
                CollectionId = CollectCreation.CollectionId,
                ProductId = Product.Id.Value
            }).Await().AsTask.Result;
        };

        It should_create_a_collect = () =>
        {
            Collect.ShouldNotBeNull();
            Collect.Id.Value.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {
            Service.DeleteAsync(Collect.Id.Value).Await();
            CollectCreation.DeleteProduct(Product.Id.Value).Await();
        };

        static ShopifyCollectService Service;

        static Collect Collect;

        static ShopifySharp.Product Product;
    }
}
