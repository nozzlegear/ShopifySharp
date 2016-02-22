using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;

namespace ShopifySharp.Tests.Product
{
    [Subject(typeof(ShopifyProductService))]
    public class When_unpublishing_a_product
    {
        Establish context = () =>
        {
            Service = new ShopifyProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = Service.CreateAsync(ProductCreation.CreateValidProducts(), new ShopifyProductCreateOptions() { Published = true }).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Product = Service.UnpublishAsync(Product.Id.Value).Await().AsTask.Result;
        };

        It should_unpublish_a_product = () =>
        {
            Product.PublishedAt.ShouldBeNull();
        };

        Cleanup after = () =>
        {
            if (Product != null)
            {
                Service.DeleteAsync(Product.Id.Value).Await();
            }
        };

        static ShopifyProductService Service;

        static ShopifyProduct Product;
    }
}
