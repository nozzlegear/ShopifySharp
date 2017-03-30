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

        public static string SecretKey { get; } = ConfigurationManager.AppSettings.Get("SecretKey");

        public static string AccessToken { get; } = ConfigurationManager.AppSettings.Get("AccessToken");

        public static string MyShopifyUrl { get; } = ConfigurationManager.AppSettings.Get("MyShopifyUrl");

        /// <summary>
        /// An access token to a shop created by a real application. This is only used for testing <see cref="RecurringChargeService"/>,
        /// because a private app cannot create/manipulate charges.
        /// </summary>
        public static string BillingAccessToken { get; } = ConfigurationManager.AppSettings.Get("BillingAccessToken");

        /// <summary>
        /// A *.myshopify.com domain corresponding to <see cref="BillingAccessToken"/>.
        /// </summary>
        public static string BillingMyShopifyUrl { get; } = ConfigurationManager.AppSettings.Get("BillingMyShopifyUrl");
    }
}
