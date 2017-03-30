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
    public class When_getting_a_list_of_products
    {
        Establish context = () =>
        {
            Service = new ShopifyProductService(Utils.MyShopifyUrl, Utils.AccessToken);

            for (var i = 0; i < 3; i++)
            {
                var product = Service.CreateAsync(ProductCreation.CreateValidProducts(), new ShopifyProductCreateOptions()
                {
                    Published = false
                }).Await().AsTask.Result;

                ProductIds.Add(product.Id.Value);
            }
        };

        Because of = () =>
        {
            Products = Service.ListAsync().Await().AsTask.Result;
        };

        It should_list_products = () =>
        {
            Products.Count().ShouldBeGreaterThanOrEqualTo(ProductIds.Count);
        };

        Cleanup after = () =>
        {
            foreach (var id in ProductIds)
            {
                Service.DeleteAsync(id).Await();
            }
        };

        static ShopifyProductService Service;

        static List<long> ProductIds = new List<long>();

        static IEnumerable<ShopifySharp.Product> Products;
    }
}
