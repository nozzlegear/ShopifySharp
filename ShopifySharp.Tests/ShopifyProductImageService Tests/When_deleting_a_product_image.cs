using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;

namespace ShopifySharp.Tests.ShopifyProductImageService_Tests
{
    [Subject(typeof(ShopifyProductImageService))]
    class When_deleting_a_product_image
    {
        Establish context = () =>
        {
            Product = ProductImageTests.CreateParentProduct().Await().AsTask.Result;
            Id = ProductImageTests.Service.CreateAsync(Product.Id.Value, ProductImageTests.CreateValidImage()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
           Ex = Catch.Exception(() => ProductImageTests.Service.DeleteAsync(Product.Id.Value, Id.Value).Await());
        };

        It should_delete_an_image = () =>
        {
            Ex.ShouldBeNull();
        };

        Cleanup after = () =>
        {
            ProductImageTests.DeleteParentProduct(Product).Await();
        };

        static Exception Ex;

        static ShopifySharp.Product Product;

        static long? Id;
    }
}
