using System;
using System.Collections.Generic;
using Xunit.Sdk;

namespace ShopifySharp.Tests
{
    /// <summary>
    /// A utility class for running tests.
    /// </summary>
    public static class Utils
    {
        private static IDictionary<string, string> _dotEnvFile;

        static Utils()
        {
            // Console.WriteLine("DIRECTORY: " + System.IO.Directory.GetCurrentDirectory());
            // dotEnvFile = DotEnvFile.DotEnvFile.LoadFile("env.yml");
        }

        /// <summary>
        /// Attempts to get an environment variable first by the key, then by 'SHOPIFYSHARP_{KEY}'. All keys must be uppercased!
        /// </summary>
        private static string Get(string key)
        {
            key = key.ToUpper();

            if (_dotEnvFile == null && System.IO.File.Exists("./env.yml"))
            {
                _dotEnvFile = DotEnvFile.LoadFile("./env.yml", true);
            }

            if (_dotEnvFile != null && _dotEnvFile.ContainsKey(key))
            {
                return _dotEnvFile[key];
            }

            var prefix = "SHOPIFYSHARP_";
            var value = Environment.GetEnvironmentVariable(key) ?? Environment.GetEnvironmentVariable(prefix + key);

            if (string.IsNullOrEmpty(value))
            {
                throw new Exception($"{nameof(key)} {key} was not found in environment variables. Add the key or {prefix + key} to your environment variables and try again.");
            }

            return value;
        }

        public static string ApiKey => Get("API_KEY");

        public static string SecretKey => Get("SECRET_KEY");

        public static string AccessToken => Get("ACCESS_TOKEN");

        public static string MultipassSecret => Get("MULTIPASS_SECRET");

        public static string MyShopifyUrl => Get("MY_SHOPIFY_URL");

        public static long OrganizationId => long.Parse(Get("ORG_ID"));

        public static string OrganizationToken => Get("ORG_TOKEN");
    }
}
