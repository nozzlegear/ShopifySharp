using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests
{
    /// <summary>
    /// A utility class for running tests.
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Attempts to get an environment variable first by the key, then by 'SHOPIFYSHARP_{KEY}'. All keys must be uppercased!
        /// </summary>
        private static string Get(string key) 
        {
            key = key.ToUpper();

            return Environment.GetEnvironmentVariable(key) ?? Environment.GetEnvironmentVariable("SHOPIFYSHARP_" + key);
        }

        public static string ApiKey { get; } = Get("API_KEY");

        public static string SecretKey { get; } = Get("SECRET_KEY");

        public static string AccessToken { get; } = Get("ACCESS_TOKEN");

        public static string MyShopifyUrl { get; } = Get("MY_SHOPIFY_URL");
    }
}
