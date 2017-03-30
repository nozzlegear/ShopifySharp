using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyProductImageService_Tests
{
    [Subject(typeof(ProductImageService))]
    class When_getting_product_images
    {
        Establish context = () =>
        {
            Product = ProductImageTests.CreateParentProduct().Await().AsTask.Result;
            Id = ProductImageTests.Service.CreateAsync(Product.Id.Value, ProductImageTests.CreateValidImage()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
            Image = ProductImageTests.Service.GetAsync(Product.Id.Value, Id.Value).Await().AsTask.Result;
        };

        It should_get_an_image = () =>
        {
            Image.ShouldNotBeNull();
            Image.Src.ShouldNotBeNull();
        };

        Cleanup after = () =>
        {
            ProductImageTests.DeleteParentProduct(Product).Await();
        };

        static ProductImage Image;

        static ShopifySharp.Product Product;

        static long? Id;
    }
}
