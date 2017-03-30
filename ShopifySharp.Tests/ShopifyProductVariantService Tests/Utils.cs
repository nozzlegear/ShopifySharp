using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyProductVariantService_Tests
{
    static class VariantUtils
    {
        static long? ProductId { get; set; }

        public static ShopifyProductVariantService Service = new ShopifyProductVariantService(Utils.MyShopifyUrl, Utils.AccessToken);

        public static string Option1 { get; } = "blue";
        
        public static double Price { get; } = 123.45;

        public static ProductVariant CreateVariant()
        {
            return new ProductVariant()
            {
                Option1 = Option1,
                Price = Price,
                Metafields = new List<ShopifySharp.MetaField>()
                {
                    new ShopifySharp.MetaField()
                    {
                        Key = "new",
                        Value = "newvalue",
                        ValueType = "string",
                        Namespace = "global",
                    }
                }
            };
        }

        public static async Task<long> GetProductId()
        {
            if (ProductId.HasValue)
            {
                return ProductId.Value;
            }

            var service = new ShopifyProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            var products = await service.ListAsync(new Filters.ShopifyProductFilter()
            {
                Limit = 1,
                Fields = "id"
            });
            
            ProductId = products.First().Id;

            return ProductId.Value;
        }
    }
}
