using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ShopifySharp;

/// <summary>
/// An abstract class for parameterizing certain objects.
/// </summary>
public abstract class Parameterizable
{
    /// <summary>
    /// Converts the object to an array of KVPs.
    /// </summary>
    public virtual IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
    {
        var output = new List<KeyValuePair<string, object>>();

        //Inspiration for this code from https://github.com/jaymedavis/stripe.net
        foreach (PropertyInfo property in GetType().GetAllDeclaredProperties())
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

            var parameter = ToSingleParameter(propName, value, property);

            output.Add(parameter);
        }

        return output;
    }

    /// <summary>
    /// Converts the given property and value to a KeyValuePair for use as a query parameter. Can be overriden to customize parameterization of a property.
    /// Will NOT be called by the <see cref="Parameterizable.ToParameters(ParameterType)"/> method if the value
    /// is null.
    /// </summary>
    /// <param name="propName">The name of the property. Will match the property's <see cref="JsonPropertyAttribute"/> name —
    /// rather than the real property name — where applicable. Use <paramref name="property"/>.Name to get the real name.</param>
    /// <param name="value">The property's value.</param>
    /// <param name="property">The property itself.</param>
    /// <returns>The new parameter.</returns>
    protected virtual KeyValuePair<string, object> ToSingleParameter(string propName, object value, PropertyInfo property)
    {
        KeyValuePair<string, object> Join<T>(IEnumerable<T> values)
        {
            return new KeyValuePair<string, object>(propName, string.Join(",", values));
        }

        switch (value)
        {
            case IEnumerable<long> longs:
                return Join(longs);
                
            case IEnumerable<int> ints:
                return Join(ints);
                
            case IEnumerable<string> strings:
                return Join(strings);
                
            case IEnumerable<bool> bools:
                return Join(bools);
        }

        var valueType = value.GetType();

        if (valueType.GetTypeInfo().IsEnum)
        {
            value = ((Enum)value).ToSerializedString();
        }

        //Dates must be serialized in YYYY-MM-DD HH:MM format.
        if (valueType == typeof(DateTime) || valueType == typeof(DateTime?))
        {
            value = ((DateTime)value).ToString("o");
        }
        else if (valueType == typeof(DateTimeOffset) || valueType == typeof(DateTimeOffset?))
        {
            value = ((DateTimeOffset)value).ToString("o");
        }

        return new KeyValuePair<string, object>(propName, value);
    }
}