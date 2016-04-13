using Newtonsoft.Json.Converters;
using System;
using Newtonsoft.Json;
using ShopifySharp.Enums;
using System.Runtime.Serialization;

namespace ShopifySharp.Converters
{
    /// <summary>
    /// A custom enum converter for all enums which returns the value 
    /// as null when the value is null or does not exist.
    /// </summary>
    public class NullableEnumConverter<T> : StringEnumConverter where T : struct
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            T parsed;
            
            if (!Enum.TryParse(reader.Value?.ToString() ?? "", true, out parsed))
            {
                // Some EnumMember values have an '_', '-' or '/' in their value and will fail the TryParse or IsDefined checks.
                // Use reflection to pull all of the enums values, get their EnumMember value and check if there's a match.

                var enumType = typeof(T);
                var enumVals = Enum.GetValues(enumType);

                foreach (var enumVal in enumVals)
                {
                    var valInfo = enumType.GetMember(enumVal.ToString());
                    var enumMember = valInfo[0].GetCustomAttributes(typeof(EnumMemberAttribute), false);

                    if (enumMember.Length == 0)
                    {
                        continue;
                    }

                    if (((EnumMemberAttribute)enumMember[0]).Value?.ToString() == reader.Value?.ToString())
                    {
                        return (T) enumVal;
                    }
                }

                //No match found. Return null.
                return null;
            }

            return parsed;
        }
    }
}
