using System;

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

            string prefix = "SHOPIFYSHARP_";
            string value = Environment.GetEnvironmentVariable(key) ?? Environment.GetEnvironmentVariable(prefix + key);

            if (string.IsNullOrEmpty(value))
            {
                throw new Exception($"{nameof(key)} {key} was not found in environment variables. Add the key or {prefix + key} to your environment variables and try again.");
            }

            return value;
        }


        // public static string ApiKey => Get("API_KEY");

        // public static string SecretKey => Get("SECRET_KEY");

        // public static string AccessToken => Get("ACCESS_TOKEN");

        // public static string MyShopifyUrl => Get("MY_SHOPIFY_URL");

        public static string ApiKey = "d82e7a5e073806a7251959c1b972fa98";

        public static string SecretKey = "5d4a92a2891fd6126c3eae7d2e32b7fd";

        public static string AccessToken = "9cf04c0100669eeb0b1dc9dd0ff2ed15";

        public static string MyShopifyUrl = "https://pgymygoatunittests.myshopify.com/";
    }
}
