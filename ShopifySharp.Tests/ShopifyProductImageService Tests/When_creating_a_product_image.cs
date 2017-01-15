using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyProductImageService_Tests
{
    [Subject(typeof(ShopifyProductImageService))]
    class When_creating_a_product_image
    {
        Establish context = () =>
        {
            Product = ProductImageTests.CreateParentProduct().Await().AsTask.Result;
        };

        Because of = () =>
        {
            Image = ProductImageTests.Service.CreateAsync(Product.Id.Value, ProductImageTests.CreateValidImage()).Await().AsTask.Result;
        };

        It should_create_an_image = () =>
        {
            Image.ShouldNotBeNull();
            Image.Src.ShouldNotBeNull();
            Image.Src.ShouldContain(ProductImageTests.ImageFileName);
        };

        Cleanup after = () =>
        {
            ProductImageTests.DeleteParentProduct(Product).Await();
        };

        static ShopifyProductImage Image;

        static ShopifyProduct Product;

        static long? Id;
    }
}
