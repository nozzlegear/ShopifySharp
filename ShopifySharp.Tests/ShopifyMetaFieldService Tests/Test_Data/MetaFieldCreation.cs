using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Test_Data
{
    class MetaFieldCreation
    {
        public static ShopifyMetaField CreateValidMetaField1()
        {
            return new ShopifyMetaField()
            {
                Namespace = "nms",
                Key = "inventory_sync_buffer1",
                Value = "5",
                ValueType = "integer",
                Description = "The inventory sync buffer is the percentage of inventory to hold back from the Shopify shop. The default value is zero. Set to a whole number.",
            };
        }

        public static ShopifyMetaField CreateValidMetaField2()
        {
            return new ShopifyMetaField()
            {
                Namespace = "nms",
                Key = "inventory_sync_buffer2",
                Value = "22",
                ValueType = "integer",
                Description = "The inventory sync buffer is the percentage of inventory to hold back from the Shopify shop. The default value is zero. Set to a whole number.",
            };
        }

        public static ShopifyMetaField CreateValidMetaField3()
        {
            return new ShopifyMetaField()
            {
                Namespace = "nms",
                Key = "inventory_sync_buffer3",
                Value = "6",
                ValueType = "integer",
                Description = "The inventory sync buffer is the percentage of inventory to hold back from the Shopify shop. The default value is zero. Set to a whole number.",
            };
        }
    }
}
