using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyClientDetails
    {
        [JsonProperty("accept_language")]
        public string AcceptLanguage { get; set; }

        [JsonProperty("browser_height")]
        public string BrowserHeight { get; set; }

        [JsonProperty("browser_ip")]
        public string BrowserIp { get; set; }

        [JsonProperty("browser_width")]
        public string BrowserWidth { get; set; }

        [JsonProperty("session_height")]
        public string SessionHeight { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
