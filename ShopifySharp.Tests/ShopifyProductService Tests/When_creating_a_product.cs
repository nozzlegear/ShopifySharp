using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Product
{
    [Subject(typeof(ProductService))]
    public class When_creating_a_product
    {
        Establish context = () =>
        {
            Service = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Product = Service.CreateAsync(ProductCreation.CreateValidProducts()).Await().AsTask.Result;
        };

        It should_create_a_product = () =>
        {
            Product.ShouldNotBeNull();
            Product.Title.ShouldNotBeNull();
            Product.Id.HasValue.ShouldBeTrue();
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
