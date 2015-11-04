using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyProductService))]
    public class When_getting_one_product
    {
        Establish context = () =>
        {
            Service = new ShopifyProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = Service.CreateAsync(ProductCreation.CreateValidProducts(), new ShopifyProductCreateOptions() { Published = false }).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Product = Service.GetAsync(Product.Id.Value).Await().AsTask.Result;
        };

        It should_not_be_null = () => Product.ShouldNotBeNull();

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
