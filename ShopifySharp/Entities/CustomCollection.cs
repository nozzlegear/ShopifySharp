using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShopifySharp
{
    /// <summary>
    /// An entity representing a Shopify Custom Collection Object.
    /// </summary>
    public class CustomCollection : ShopifyObject
    {
        /// <summary>
        /// The description of the Custom collection, complete with HTML markup. Many templates display this on their Custom collection page.
        /// </summary>
        [JsonProperty("body_html")]
        public string BodyHtml { get; set; }


        /// <summary>
        /// A human-friendly unique string for the Custom collection automatically generated from its title. This is used in shop themes by the Liquid templating language to refer to the Custom collection. Limit of 255 characters.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }

        /// <summary>
        /// The collection image.
        /// </summary>
        [JsonProperty("image")]
        public CustomCollectionImage Image { get; set; }

        /// <summary>
        /// Whether the collection is published or not.
        /// </summary>
        [JsonProperty("published")]
        public bool Published { get; set; }

        /// <summary>
        /// This can have two different types of values, depending on whether the Custom collection has been published (i.e., made visible to customers):
        /// If the Custom collection is published, this value is the date and time when it was published.The API returns this value in ISO 8601 format.
        /// If the Custom collection is hidden (i.e., not published), this value is null. Changing a Custom collection's status from published to hidden changes its published_at property to null.
        /// </summary>
        [JsonProperty("published_at")]
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// The sales channels in which the Custom collection is visible.
        /// </summary>
        [JsonProperty("published_scope")]
        public string PublishedScope { get; set; }

        /// <summary>
        /// Attaches additional metadata to a shop's resources:      
        /// </summary>
        [JsonProperty("metafield")]
        public MetaField MetaField { get; set; }


        /// <summary>
        /// The order in which products in the Custom collection appear
        /// </summary>
        [JsonProperty("sort_order")]
        public string SortOrder { get; set; }

        /// <summary>
        /// The suffix of the template you are using. By default, the original template is called product.liquid, without any suffix. Any additional templates will be: product.suffix.liquid.
        /// </summary>
        [JsonProperty("template_suffix")]
        public string TemplateSuffix { get; set; }

        /// <summary>
        /// The name of the Custom collection. Limit of 255 characters.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The date and time when the Custom collection was last modified. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }


        /// <summary>
        /// The collection of collects associated to this custom collection
        /// </summary>
        [JsonProperty("collects")]
        public IEnumerable<Collect> Collects { get; set; }
    }
}
