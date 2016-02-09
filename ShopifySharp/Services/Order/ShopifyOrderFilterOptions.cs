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
    public class ShopifyOrderFilterOptions : ShopifyFilterOptions
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
        public long? SinceId { get; set; }

        /// <summary>
        /// The status of orders to retrieve. Default is <see cref="ShopifyOrderStatus.Any"/>.
        /// </summary>
        [JsonProperty("status")]
        public ShopifyOrderStatus? Status { get; set; } = ShopifyOrderStatus.Any;

        /// <summary>
        /// The financial status of orders to retrieve. Leave this null to retrieve orders with any financial status.
        /// </summary>
        [JsonProperty("financial_status")]
        public ShopifyOrderFinancialStatus? FinancialStatus { get; set; }

        /// <summary>
        /// The fulfillment status of orders to retrieve. Leave this null to retrieve orders with any fulfillment status.
        /// </summary>
        [JsonProperty("fulfillment_status")]
        public ShopifyFulfillmentStatus? FulfillmentStatus { get; set; }

        /// <summary>
        /// Show orders created after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTime? CreatedAtMin { get; set; } = null;

        /// <summary>
        /// Show orders created before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTime? CreatedAtMax { get; set; } = null;

        /// <summary>
        /// Show orders last updated after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTime? UpdatedAtMin { get; set; } = null;

        /// <summary>
        /// Show orders last updated before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_max")]
        public DateTime? UpdatedAtMax { get; set; } = null;

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
                var param =  new Parameter()
                {
                    Name = propName,
                    Type = type,
                    Value = string.Join(",", value as IEnumerable<long> )
                };

                return param;
            }
            
            return base.ToSingleParameter(propName, value, property, type);
        }
    }
}
