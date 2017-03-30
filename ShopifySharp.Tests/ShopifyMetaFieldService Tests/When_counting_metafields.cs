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
    public class When_counting_metafields
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
            Result = Service.CountAsync(Product.Id, "products").Await().AsTask.Result;
        };

        It should_count_metafields = () => Result.ShouldBeGreaterThanOrEqualTo(1);

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

        static ProductService ProductService;

        static int Result;

        static ShopifySharp.MetaField MetaField;

        static ShopifySharp.Product Product;
    }
}
