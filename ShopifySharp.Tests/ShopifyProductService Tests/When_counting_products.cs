using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Product
{
    [Subject(typeof(ShopifyProductService))]
    public class When_counting_products
    {
        Establish context = () =>
        {
            Service = new ShopifyProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = Service.CreateAsync(ProductCreation.CreateValidProducts(), new ShopifyProductCreateOptions() { Published = false }).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Result = Service.CountAsync().Await().AsTask.Result;
        };

        It should_count_products = () => Result.ShouldBeGreaterThanOrEqualTo(1);

        Cleanup after = () =>
        {
            if (Product != null)
            {
                Service.DeleteAsync(Product.Id.Value).Await();
            }
        };

        static ShopifyProductService Service;

        static int Result;

        static ShopifySharp.Product Product;
    }
}
