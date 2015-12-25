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
    class When_deleting_a_collect
    {
        Establish context = () =>
        {
            Service = new ShopifyCollectService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = CollectCreation.CreateProduct().Await().AsTask.Result;

            Id = Service.CreateAsync(new ShopifyCollect()
            {
                CollectionId = CollectCreation.CollectionId,
                ProductId = Product.Id.Value
            }).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            Service.DeleteAsync(Id).Await();
        };

        It should_delete_a_collect = () =>
        {
            //Passes if no exception was thrown.
        };

        Cleanup after = () =>
        {
            CollectCreation.DeleteProduct(Product.Id.Value).Await();
        };

        static ShopifyCollectService Service;

        static long Id;

        static ShopifyProduct Product;
    }
}
