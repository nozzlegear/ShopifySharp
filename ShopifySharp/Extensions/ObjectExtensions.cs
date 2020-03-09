using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ShopifySharp
{
    internal static class ObjectExtensions
    {
        /// <summary>
        /// Converts the object to a dictionary.
        /// </summary>
        /// <returns>The object as a <see cref="IDictionary{String, Object}"/>.</returns>
        public static IDictionary<string, object> ToDictionary(this object obj, IEnumerable<string> fields = null)
        {
            IDictionary<string, object> output = new Dictionary<string, object>();
            var propInfos = obj.GetType().GetAllDeclaredProperties();

            if (fields != null)
            {
                if (fields.Any(f => f.Contains('.')))
                {
                    throw new NotImplementedException("Limiting properties of child options is not supported.");
                }
                propInfos = propInfos.Where(pi => fields.Contains(pi.Name));
            }

            //Inspiration for this code from https://github.com/jaymedavis/stripe.net
            foreach (PropertyInfo property in propInfos)
            {
                object value = property.GetValue(obj, null);
                string propName = property.Name;
                if (value == null) continue;

                if (property.CustomAttributes.Any(x => x.AttributeType == typeof(JsonPropertyAttribute)))
                {
                    //Get the JsonPropertyAttribute for this property, which will give us its JSON name
                    JsonPropertyAttribute attribute = property.GetCustomAttributes(typeof(JsonPropertyAttribute), false).Cast<JsonPropertyAttribute>().FirstOrDefault();

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