using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyProductImageService_Tests
{
    [Subject(typeof(ShopifyProductImageService))]
    class When_updating_product_images
    {
        Establish context = () =>
        {
            Product = ProductImageTests.CreateParentProduct().Await().AsTask.Result;
            Image = ProductImageTests.Service.CreateAsync(Product.Id.Value, ProductImageTests.CreateValidImage()).Await().AsTask.Result;

            Image.Position = 2;
        };

        Because of = () =>
        {
            Image = ProductImageTests.Service.UpdateAsync(Product.Id.Value, Image).Await().AsTask.Result;
        };

        It should_update_an_image = () =>
        {
            Image.ShouldNotBeNull();
            Image.Src.ShouldNotBeNull();
            Image.Position.ShouldEqual(2);
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
