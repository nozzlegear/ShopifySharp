using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Tests.ShopifyEventService_Tests
{
    [Subject(typeof(ShopifyEventService))]
    class When_creating_a_product
    {
        Establish context = () =>
        {
            Service = new ShopifyEventService(Utils.MyShopifyUrl, Utils.AccessToken);
            ProductService = new ShopifyProductService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Product = ProductService.CreateAsync(ProductCreation.CreateValidProducts(), new ShopifyProductCreateOptions() { Published = false }).Await().AsTask.Result;
            Events = Service.ListAsync().Await().AsTask.Result;
        };
        
        It should_count_collects = () =>
        {
            Events.ShouldNotBeEmpty();
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
        
        static ShopifyProduct Product;

        static IEnumerable<ShopifyEvent> Events;
    }
}
