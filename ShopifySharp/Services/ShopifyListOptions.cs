using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyListOptions
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

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
        /// Show customers created after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_min")]
        public string CreatedAtMin { get; set; }

        /// <summary>
        /// Show customers created before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_max")]
        public string CreatedAtMax { get; set; }

        /// <summary>
        /// Show customers last updated after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_min")]
        public string UpdatedAtMin { get; set; }

        /// <summary>
        /// Show customers last updated before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_max")]
        public string UpdatedAtMax { get; set; }

        /// <summary>
        /// Converts the object to an array of RestSharp parameters.
        /// </summary>
        /// <returns>The array of RestSharp parameters.</returns>
        public IEnumerable<Parameter> ToParameters(ParameterType type)
        {
            List<Parameter> output = new List<Parameter>();

            //Inspiration for this code from https://github.com/jaymedavis/stripe.net
            foreach (PropertyInfo property in GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                object value = property.GetValue(this, null);
                if (value == null) continue;

                //Get the JsonPropertyAttribute for this property, which will give us its JSON name
                JsonPropertyAttribute attribute = property.GetCustomAttributes(typeof(JsonPropertyAttribute), false).Cast<JsonPropertyAttribute>().FirstOrDefault();

                output.Add(new Parameter()
                {
                    Name = attribute != null ? attribute.PropertyName : property.Name,
                    Value = value,
                    Type = type
                });
            }

            return output;
        }
    }
}
