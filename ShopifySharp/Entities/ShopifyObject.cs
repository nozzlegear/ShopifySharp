using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public abstract class ShopifyObject
    {
        /// <summary>
        /// The object's unique id.
        /// </summary>
        /// <remarks>
        /// Some object ids are longer than the max int32 value. Using long instead.
        /// Marked as nullable due to issues I've run into when trying to create a resource. If Id is present when creating, 
        /// Shopify will try to find that resource. By default it's set to 0 when not null, so the resource won't exist and 
        /// Shopify will return a 404 Not Found. This is most obvious when creating a customer with a <see cref="Address"/> 
        /// and the <see cref="Address"/> Id set to 0.
        /// </remarks>
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("admin_graphql_api_id")]
        public string AdminGraphQLAPIId { get; set; }

        /// <summary>
        /// Converts the object to an IDictionary<string, object> for eventual serialization to JSON. Can be overridden for fine-grained control of the object's serialization.
        /// </summary>
        public virtual IDictionary<string, object> ToJsonDictionary()
        {
            IDictionary<string, object> output = new Dictionary<string, object>();

            // Inspiration for this code from https://github.com/jaymedavis/stripe.net
            foreach (PropertyInfo property in obj.GetType().GetAllDeclaredProperties())
            {
                object value = property.GetValue(obj, null);
                string propName = property.Name;
                if (value == null) continue;

                if (property.CustomAttributes.Any(x => x.AttributeType == typeof(JsonPropertyAttribute)))
                {
                    // Get the JsonPropertyAttribute for this property, which will give us its JSON name
                    JsonPropertyAttribute attribute = property
                        .GetCustomAttributes(typeof(JsonPropertyAttribute), false)
                        .Cast<JsonPropertyAttribute>()
                        .FirstOrDefault();

                    propName = attribute != null ? attribute.PropertyName : property.Name;
                }

                if (value.GetType().GetTypeInfo().IsEnum)
                {
                    value = ((Enum)value).ToSerializedString();
                }

                output.Add(propName, value);
            }

            return output;
        }
    }
}
