using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace ShopifySharp.Tests.MetaField
{
    [Subject(typeof(ShopifyMetaFieldService))]
    public class When_updating_a_metafield
    {
        Establish context = () =>
        {
            ProductService = new ShopifyProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = ProductService.CreateAsync(ProductCreation.CreateValidProducts(), new ShopifyProductCreateOptions() { Published = false }).Await().AsTask.Result;

            Service = new ShopifyMetaFieldService(Utils.MyShopifyUrl, Utils.AccessToken);
            MetaField = Service.CreateAsync(MetaFieldCreation.CreateValidMetaField2(), Product.Id, "products").Await().AsTask.Result;
        };

        Because of = () =>
        {
            MetaField.Value = "45";
            MetaField = Service.UpdateAsync(MetaField).Await().AsTask.Result;
        };

        It should_update_a_metafield = () => MetaField.Value.ShouldEqual(MetaField.Value);

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
