using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.MetaField
{
    [Subject(typeof(ShopifyMetaFieldService))]
    public class When_getting_one_metafield
    {
        Establish context = () =>
        {
            ProductService = new ShopifyProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = ProductService.CreateAsync(ProductCreation.CreateValidProducts()).Await().AsTask.Result;

            Service = new ShopifyMetaFieldService(Utils.MyShopifyUrl, Utils.AccessToken);
            MetaField = Service.CreateAsync(MetaFieldCreation.CreateValidMetaField2(), Product.Id, "products").Await().AsTask.Result;
        };

        Because of = () =>
        {
            MetaField = Service.GetAsync(MetaField.Id.Value).Await().AsTask.Result;
        };

        It should_get_a_metafield = () =>
        {
            MetaField.ShouldNotBeNull();
            MetaField.Id.HasValue.ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            if (MetaField != null)
            {
                Service.DeleteAsync(MetaField.Id.Value).Await();
            }

            if (Product != null)
            {
                ProductService.DeleteAsync(Product.Id.Value).Await();
            }
        };

        static ShopifyMetaFieldService Service;

        static ShopifyMetaField MetaField;

        static ShopifyProduct Product;

        static ShopifyProductService ProductService;
    }
}
