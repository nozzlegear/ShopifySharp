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
    public abstract class Parameterizable
    {
        /// <summary>
        /// Converts the object to a dictionary. Ideal for <see cref="RestRequest.AddJsonBody(object)"./>
        /// </summary>
        /// <returns>The object as a <see cref="IDictionary{String, Object}"/>.</returns>
        public IDictionary<string, object> ToDictionary()
        {
            IDictionary<string, object> output = new Dictionary<string, object>();

            //Inspiration for this code from https://github.com/jaymedavis/stripe.net
            foreach (PropertyInfo property in GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                object value = property.GetValue(this, null);
                if (value == null) continue;

                //Get the JsonPropertyAttribute for this property, which will give us its JSON name
                JsonPropertyAttribute attribute = property.GetCustomAttributes(typeof(JsonPropertyAttribute), false).Cast<JsonPropertyAttribute>().FirstOrDefault();

                output.Add(attribute != null ? attribute.PropertyName : property.Name, value);
            }

            return output;
        }

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
