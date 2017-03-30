using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.MetaField
{
    public class When_deleting_a_metafield
    {
        Establish context = () =>
        {
            ProductService = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = ProductService.CreateAsync(ProductCreation.CreateValidProducts()).Await().AsTask.Result;

            Service = new MetaFieldService(Utils.MyShopifyUrl, Utils.AccessToken);
            MetaField = Service.CreateAsync(MetaFieldCreation.CreateValidMetaField1(), Product.Id, "products").Await().AsTask.Result;
        };

        Because of = () =>
        {
            Service.DeleteAsync(MetaField.Id.Value).Await();
        };

        It should_delete_a_product = () =>
        {
            //Passes if no exception was thrown.
        };

        Cleanup after = () =>
        {
            ProductService.DeleteAsync(Product.Id.Value).Await();
        };

        static MetaFieldService Service;

        static ShopifySharp.MetaField MetaField;

        static ProductService ProductService;

        static ShopifySharp.Product Product;
    }
}
