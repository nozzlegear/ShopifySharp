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
    public class When_getting_a_list_of_filtered_metafields
    {
        Establish context = () =>
        {
            ProductService = new ShopifyProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = ProductService.CreateAsync(ProductCreation.CreateValidProducts()).Await().AsTask.Result;

            Service = new ShopifyMetaFieldService(Utils.MyShopifyUrl, Utils.AccessToken);

            for (var i = 1; i <= 3; i++)
            {
                var metafieldToCreate = MetaFieldCreation.CreateValidMetaField1();
                if (i == 2)
                {
                    metafieldToCreate = MetaFieldCreation.CreateValidMetaField2();
                }

                if (i == 3)
                {
                    metafieldToCreate = MetaFieldCreation.CreateValidMetaField3();
                }

                var metafield = Service.CreateAsync(metafieldToCreate, Product.Id, "products").Await().AsTask.Result;

                MetaFieldIds.Add(metafield.Id.Value);
            }
        };

        Because of = () =>
        {
            MetaFields = Service.ListAsync(Product.Id, "products", new ShopifyMetaFieldFilterOptions() { Namespace = "nms" }).Await().AsTask.Result;
        };

        It should_list_metafields_with_specific_namespace = () =>
        {
            MetaFields.Count().ShouldEqual(MetaFieldIds.Count);
            MetaFields.All(m => MetaFieldIds.Contains(m.Id.Value)).ShouldBeTrue();
        };

        Cleanup after = () =>
        {
            foreach (var id in MetaFieldIds)
            {
                Service.DeleteAsync(id).Await();
            }
            ProductService.DeleteAsync(Product.Id.Value).Await();
        };

        static ShopifyMetaFieldService Service;

        static ShopifyProductService ProductService;

        static ShopifyProduct Product;

        static List<long> MetaFieldIds = new List<long>();

        static IEnumerable<ShopifyMetaField> MetaFields;
    }
}
