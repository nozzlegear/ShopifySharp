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
    public class When_deleting_a_product
    {
        Establish context = () =>
        {
            Service = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = Service.CreateAsync(ProductCreation.CreateValidProducts(), new ProductCreateOptions() { Published = false }).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Service.DeleteAsync(Product.Id.Value).Await();
        };

        It should_delete_a_product = () =>
        {
            //Passes if no exception was thrown.
        };

        static ProductService Service;

        static ShopifySharp.Product Product;
    }
}
