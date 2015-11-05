using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace ShopifySharp.Tests.Product
{
    [Subject(typeof(ShopifyProductService))]
    public class When_getting_a_list_of_products
    {
        Establish context = () =>
        {
            Service = new ShopifyProductService(Utils.MyShopifyUrl, Utils.AccessToken);

            ProductId = Service.CreateAsync(ProductCreation.CreateValidProducts(), new ShopifyProductCreateOptions() { Published = false }).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            Products = Service.ListAsync(new ShopifyProductFilterOptions() { Ids = new[] { ProductId } }).Await().AsTask.Result;
        };

        It should_retrieve_a_list_of_products = () => Products.Count().ShouldBeGreaterThanOrEqualTo(1);

        It should_retrieve_a_list_of_products_with_the_correct_id = () => Products.Any(p => p.Id == ProductId);

        Cleanup after = () =>
        {
            if (Products != null)
            {
                Service.DeleteAsync(ProductId).Await();
            }
        };

        static ShopifyProductService Service;
        static long ProductId;

        static IEnumerable<ShopifyProduct> Products;
    }
}
