using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    public class ClientDetails
    {
        /// <summary>
        /// Shopify does not offer documentation for this field.
        /// </summary>
        [JsonProperty("accept_language")]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The browser screen height in pixels, if available.
        /// </summary>
        [JsonProperty("browser_height")]
        public int? BrowserHeight { get; set; }

        /// <summary>
        /// The browser IP address.
        /// </summary>
        [JsonProperty("browser_ip")]
        public string BrowserIp { get; set; }

        /// <summary>
        /// The browser screen width in pixels, if available.
        /// </summary>
        [JsonProperty("browser_width")]
        public int? BrowserWidth { get; set; }

        /// <summary>
        /// A hash of the session.
        /// </summary>
        [JsonProperty("session_hash")]
        public string SessionHash { get; set; }

        /// <summary>
        /// The browser's user agent string.
        /// </summary>
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
