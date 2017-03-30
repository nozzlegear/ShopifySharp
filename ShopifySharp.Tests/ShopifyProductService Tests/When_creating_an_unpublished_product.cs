using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;

namespace ShopifySharp.Tests.Product
{
    [Subject(typeof(ProductService))]
    public class When_creating_an_unpublished_product
    {
        Establish context = () =>
        {
            Service = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            var options = new ProductCreateOptions()
            {
                Published = false
            };
            Product = Service.CreateAsync(ProductCreation.CreateValidProducts(), options).Await().AsTask.Result;
        };

        It should_create_an_unpublished_product = () =>
        {
            Product.ShouldNotBeNull();
            Product.Title.ShouldNotBeNull();
            Product.Id.HasValue.ShouldBeTrue();
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
