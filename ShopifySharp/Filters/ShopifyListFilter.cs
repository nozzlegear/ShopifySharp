using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Reflection;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// A generic class for filtering the results of a .ListAsync command.
    /// </summary>
    public class ShopifyListFilter : ShopifyCountFilter
    {
        /// <summary>
        /// An optional array of order ids to retrieve. 
        /// </summary>
        [JsonProperty("ids")]
        public IEnumerable<long> Ids { get; set; }

        /// <summary>
        /// Limit the amount of results. Default is 50, max is 250.
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Page of results to be returned. Default is 1.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// An optional, comma-separated list of fields to include in the response.
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }

        /// <summary>
        /// Parameterizes this class, with special handling for <see cref="Ids"/>.
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
