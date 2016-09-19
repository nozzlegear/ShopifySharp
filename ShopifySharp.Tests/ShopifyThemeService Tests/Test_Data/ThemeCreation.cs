using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyThemeService_Tests.Test_Data
{
    public static class ThemeCreation
    {
        /// <summary>
        /// A URL pointing to a zipped up Shopify theme. Can be used with ShopifyThemeService.CreateAsync.
        /// </summary>
        public static string ZipUrl = "https://ironstorage.blob.core.windows.net/public-downloads/ShopifySharp/shopify_test_theme_for_shopifysharp.zip";

        public static ShopifyTheme CreateValidTheme()
        {
            return new ShopifyTheme()
            {
                Name = "My new theme.",
                Role = "unpublished"
            };
        }
    }
}
