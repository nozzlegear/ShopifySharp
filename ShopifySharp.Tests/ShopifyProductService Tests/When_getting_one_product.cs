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
    public class When_getting_one_product
    {
        Establish context = () =>
        {
            Service = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = Service.CreateAsync(ProductCreation.CreateValidProducts(), new ProductCreateOptions() { Published = false }).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Product = Service.GetAsync(Product.Id.Value).Await().AsTask.Result;
        };

        It should_retrieve_a_product = () => Product.ShouldNotBeNull();

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
