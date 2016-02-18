using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Test_Data
{
    public static class PageCreation
    {
        public static ShopifyPage CreateValidPages()
        {
            return new ShopifyPage()
            {
                CreatedAt = DateTime.UtcNow,
                Title = "Burton Custom Freestlye 151",
                BodyHtml = "<strong>Good snowboard!</strong>",
            };
        }

        public static ShopifyPage CreateValidPagesWithMetafield()
        {
            return new ShopifyPage()
            {
                CreatedAt = DateTime.UtcNow,
                Title = "Burton Custom Freestlye 151",
                BodyHtml = "<strong>Good snowboard!</strong>",
                Metafields = new List<ShopifyMetaField>() { PageCreation.CreateValidPageMetafield() }
            };
        }

        public static ShopifyMetaField CreateValidPageMetafield()
        {
            return new ShopifyMetaField()
            {
               Namespace = "SSUnitTests",
               Key = "UnitText1",
               Value = "keyvalue",
               ValueType = "string",
               Description = "test page metafield"
            };
        }


    }
}
