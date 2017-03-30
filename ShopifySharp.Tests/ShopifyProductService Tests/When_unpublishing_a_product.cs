using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;

namespace ShopifySharp.Tests.Product
{
    [Subject(typeof(ProductService))]
    public class When_unpublishing_a_product
    {
        Establish context = () =>
        {
            Service = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = Service.CreateAsync(ProductCreation.CreateValidProducts(), new ProductCreateOptions() { Published = true }).Await().AsTask.Result;
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

        static ProductService Service;

        static ShopifySharp.Product Product;
    }
}
