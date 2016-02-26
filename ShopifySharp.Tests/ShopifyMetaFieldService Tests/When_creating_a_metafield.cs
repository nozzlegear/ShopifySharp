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
    public class When_creating_a_metafield
    {
        Establish context = () =>
        {
            ProductService = new ShopifyProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            Service = new ShopifyMetaFieldService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            Product = ProductService.CreateAsync(ProductCreation.CreateValidProducts()).Await().AsTask.Result;
            MetaField = Service.CreateAsync(MetaFieldCreation.CreateValidMetaField1(), Product.Id, "products").Await().AsTask.Result;
        };

        It should_create_a_metafield = () =>
        {
            MetaField.ShouldNotBeNull();
            MetaField.Namespace.ShouldNotBeNull();
            MetaField.Key.ShouldNotBeNull();
            MetaField.Value.ShouldNotBeNull();
            MetaField.ValueType.ShouldNotBeNull();
            MetaField.OwnerId.ShouldNotBeNull();
            MetaField.OwnerResource.ShouldMatch("product");
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

        static ShopifyProductService ProductService;

        static ShopifyProduct Product;
    }
}
