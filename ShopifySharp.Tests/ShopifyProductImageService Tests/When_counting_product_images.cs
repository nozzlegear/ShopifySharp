using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyProductImageService_Tests
{
    [Subject(typeof(ShopifyProductImageService))]
    class When_counting_product_images
    {
        Establish context = () =>
        {
            Product = ProductImageTests.CreateParentProduct().Await().AsTask.Result;

            for (var i = 0; i < 3; i ++)
            {
                ProductImageTests.Service.CreateAsync(Product.Id.Value, ProductImageTests.CreateValidImage()).Await();
            }
        };

        Because of = () =>
        {
            Count = ProductImageTests.Service.CountAsync(Product.Id.Value).Await().AsTask.Result;
        };

        It should_count_images = () =>
        {
            Count.ShouldBeGreaterThanOrEqualTo(3);
        };

        Cleanup after = () =>
        {
            ProductImageTests.DeleteParentProduct(Product).Await();
        };
        
        static ShopifySharp.Product Product;

        static int Count;
    }
}
