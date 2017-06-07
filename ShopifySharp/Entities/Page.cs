using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// An entity representing a Shopify product.
    /// </summary>
    public class Page : ShopifyObject
    {
        /// <summary>
        /// The name of the page. 
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The content of the page, complete with HTML formatting.
        /// </summary>
        [JsonProperty("body_html")]
        public string BodyHtml { get; set; }

        /// <summary>
        /// The date and time when the page was created. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("created_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the page was last modified. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("updated_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// The date and time when the page was published. The API returns this value in ISO 8601 format. 
        /// </summary>
        [JsonProperty("published_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? PublishedAt { get; set; }

        /// <summary>
        /// A human-friendly unique string for the page automatically generated from its title.
        /// They are used by the Liquid templating language to refer to objects.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }

        /// <summary>
        /// The suffix of the liquid template being used.
        /// By default, the original template is called product.liquid, without any suffix.
        /// Any additional templates will be: product.suffix.liquid.
        /// </summary>
        [JsonProperty("template_suffix")]
        public string TemplateSuffix { get; set; }

        /// <summary>
        /// Attaches additional information to a shop's resources.
        /// </summary>
        [JsonProperty("metafields")]
        public IEnumerable<MetaField> Metafields { get; set; }
    }
}
