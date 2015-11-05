using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Test_Data
{
    public static class ProductCreation
    {
        public static ShopifyProduct CreateValidProducts()
        {
            return new ShopifyProduct()
            {
                CreatedAt = DateTime.UtcNow,
                Title = "Burton Custom Freestlye 151",
                Vendor = "Burton",
                BodyHtml = "<strong>Good snowboard!</strong>",
                ProductType = "Snowboard",
                Images = new List<ShopifyProductImage> { new ShopifyProductImage { Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==" } },
            };
        }
    }
}
