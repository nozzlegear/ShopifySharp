using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Test_Data
{
    public static class PageCreation
    {
        public static Page CreateValidPages()
        {
            return new ShopifySharp.Page()
            {
                CreatedAt = DateTime.UtcNow,
                Title = "Burton Custom Freestlye 151",
                BodyHtml = "<strong>Good snowboard!</strong>",
            };
        }

        public static Page CreateValidPagesWithMetafield()
        {
            return new ShopifySharp.Page()
            {
                CreatedAt = DateTime.UtcNow,
                Title = "Burton Custom Freestlye 151",
                BodyHtml = "<strong>Good snowboard!</strong>",
                Metafields = new List<ShopifySharp.MetaField>() { PageCreation.CreateValidPageMetafield() }
            };
        }

        public static MetaField CreateValidPageMetafield()
        {
            return new ShopifySharp.MetaField()
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
