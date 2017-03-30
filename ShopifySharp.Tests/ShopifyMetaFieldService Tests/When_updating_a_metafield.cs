using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.MetaField
{
    [Subject(typeof(MetaFieldService))]
    public class When_updating_a_metafield
    {
        Establish context = () =>
        {
            ProductService = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = ProductService.CreateAsync(ProductCreation.CreateValidProducts(), new ProductCreateOptions() { Published = false }).Await().AsTask.Result;

            Service = new MetaFieldService(Utils.MyShopifyUrl, Utils.AccessToken);
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

        static MetaFieldService Service;

        static ShopifySharp.MetaField MetaField;

        static ProductService ProductService;

        static ShopifySharp.Product Product;
    }
}
