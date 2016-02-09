using Newtonsoft.Json;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Reflection;

namespace ShopifySharp
{
    public class ShopifyProductFilterOptions : ShopifyFilterOptions
    {
        /// <summary>
        /// An optional array of order ids to retrieve. 
        /// </summary>
        [JsonProperty("ids")]
        public IEnumerable<long> Ids { get; set; }

        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; } = null;

        /// <summary>
        /// Filter by product title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = null;

        /// <summary>
        /// Filter by product vendor.
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; } = null;

        /// <summary>
        /// Filter by product handle.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; } = null;

        /// <summary>
        /// Filter by product type.
        /// </summary>
        [JsonProperty("product_type")]
        public string ProductType { get; set; } = null;

        /// <summary>
        /// Filter by collection id.
        /// </summary>
        [JsonProperty("collecion_id")]
        public long? CollectionId { get; set; } = null;

        /// <summary>
        /// Show products created after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTime? CreatedAtMin { get; set; } = null;

        /// <summary>
        /// Show products created before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTime? CreateAtMax { get; set; } = null;

        /// <summary>
        /// Show products last updated after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTime? UpdateAtMin { get; set; } = null;

        /// <summary>
        /// Show products last updated before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_max")]
        public DateTime? UpdateAtMax { get; set; } = null;

        /// <summary>
        /// Show products published after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("published_at_min")]
        public DateTime? PublishedAtMin { get; set; } = null;

        /// <summary>
        /// Show products published before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("published_at_max")]
        public DateTime? PublishedAtMax { get; set; } = null;

        /// <summary>
        /// Puublished Status.
        /// published - Show only published products, unpublished - Show only unpublished products, any - Show all products(default)
        /// </summary>
        [JsonProperty("published_status")]
        public string PublishedStatus { get; set; } = null;

        /// <summary>
        /// Parameterizes this <see cref="ShopifyOrderFilterOptions"/> class, with special handling for <see cref="Ids"/>.
        /// </summary>
        /// <param name="propName">The name of the property. Will match the property's <see cref="JsonPropertyAttribute"/> name — 
        /// rather than the real property name — where applicable. Use <paramref name="property"/>.Name to get the real name.</param>
        /// <param name="value">The property's value.</param>
        /// <param name="property">The property itself.</param>
        /// <param name="type">The type of parameter to create.</param>
        /// <returns>The new parameter.</returns>
        public override Parameter ToSingleParameter(string propName, object value, PropertyInfo property, ParameterType type)
        {
            if (propName == "ids" || propName == "Ids")
            {
                //RestSharp does not automatically convert arrays into querystring params.
                var param = new Parameter()
                {
                    Name = propName,
                    Type = type,
                    Value = string.Join(",", value as IEnumerable<long>)
                };

                return param;
            }

            return base.ToSingleParameter(propName, value, property, type);
        }
    }
}
