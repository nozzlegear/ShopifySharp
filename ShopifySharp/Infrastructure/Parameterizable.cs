using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data.Metadata.Edm;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// An abstract class for parameterizing certain objects.
    /// </summary>
    public abstract class Parameterizable
    {
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
                string propName = property.Name;

                if (value == null)
                {
                    continue;
                }

                if (property.CustomAttributes.Any(x => x.AttributeType == typeof(JsonPropertyAttribute)))
                {
                    //Get the JsonPropertyAttribute for this property, which will give us its JSON name
                    JsonPropertyAttribute attribute = property.GetCustomAttributes(typeof(JsonPropertyAttribute), false).Cast<JsonPropertyAttribute>().FirstOrDefault();

                    propName = attribute != null ? attribute.PropertyName : property.Name;
                }

                var parameter = ToSingleParameter(propName, value, property, type);

                output.Add(parameter);
            }

            return output;
        }

        /// <summary>
        /// Converts the given property and value to a parameter. Can be overriden to customize parameterization of a property. 
        /// Will NOT be called by the <see cref="Parameterizable.ToParameters(ParameterType)"/> method if the value 
        /// is null.
        /// </summary>
        /// <param name="propName">The name of the property. Will match the property's <see cref="JsonPropertyAttribute"/> name — 
        /// rather than the real property name — where applicable. Use <paramref name="property"/>.Name to get the real name.</param>
        /// <param name="value">The property's value.</param>
        /// <param name="property">The property itself.</param>
        /// <param name="type">The type of parameter to create.</param>
        /// <returns>The new parameter.</returns>
        public virtual Parameter ToSingleParameter(string propName, object value, PropertyInfo property, ParameterType type)
        {
            Type valueType = value.GetType();

            if (valueType.IsEnum)
            {
                value = ((Enum)value).ToSerializedString();
            }
            
            return new Parameter()
            {
                Name = propName,
                Value = value,
                Type = type
            };
        }
    }
}
