using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;

namespace ShopifySharp.Tests.ShopifyEventService_Tests
{
    [Subject(typeof(ShopifyEventService))]
    class When_counting_events
    {
        Establish context = () =>
        {
            Service = new ShopifyEventService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = ProductService.CreateAsync(ProductCreation.CreateValidProducts(), new ShopifyProductCreateOptions() { Published = false }).Await().AsTask.Result;
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
            if (Product != null)
            {
                ProductService.DeleteAsync(Product.Id.Value).Await();
            }
        };

        static ShopifyEventService Service;

        static ShopifyProductService ProductService;

        static long Id;

        static int Count;

        static ShopifyProduct Product;
    }
}
