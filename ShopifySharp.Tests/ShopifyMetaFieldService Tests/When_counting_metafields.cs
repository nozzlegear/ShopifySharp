using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShopifySharp.Tests.MetaField
{
    [Subject(typeof(ShopifyMetaFieldService))]
    public class When_counting_metafields
    {
        Establish context = () =>
        {
            ProductService = new ShopifyProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = ProductService.CreateAsync(ProductCreation.CreateValidProducts()).Await().AsTask.Result;
            Service = new ShopifyMetaFieldService(Utils.MyShopifyUrl, Utils.AccessToken);
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

        static ShopifyMetaFieldService Service;

        static ShopifyProductService ProductService;

        static int Result;

        static ShopifyMetaField MetaField;

        static ShopifyProduct Product;
    }
}
