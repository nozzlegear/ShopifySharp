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
        public static string ApiKey { get; } = ConfigurationManager.AppSettings.Get("ApiKey");

        public static string AccessToken { get; } = ConfigurationManager.AppSettings.Get("AccessToken");

        public static string MyShopifyUrl { get; } = ConfigurationManager.AppSettings.Get("MyShopifyUrl");
    }
}
