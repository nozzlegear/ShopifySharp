using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;

namespace ShopifySharp.Tests.Product
{
    [Subject(typeof(ShopifyProductService))]
    public class When_creating_an_unpublished_product
    {
        Establish context = () =>
        {
            Service = new ShopifyProductService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            var options = new ShopifyProductCreateOptions()
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

        static ShopifyProductService Service;

        static ShopifySharp.Product Product;
    }
}
