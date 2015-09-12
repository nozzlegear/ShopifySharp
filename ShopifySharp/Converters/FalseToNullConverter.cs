using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Converters
{
    /// <summary>
    /// A custom boolean converter that converts False to null and null to False.
    /// </summary>
    public class FalseToNullConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.Value?.ToString() == null || reader.Value?.ToString() == "")
            {
                return false;
            }
            else
            {
                bool output = false;

                if (bool.TryParse(reader.Value.ToString(), out output))
                {
                    return output;
                }
                else
                {
                    throw new JsonReaderException($"Cannot convert given JSON value with {nameof(FalseToNullConverter)}.");
                }
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                bool boolean = bool.Parse(value.ToString());

                if(boolean == false)
                {
                    writer.WriteNull();
                }
                else
                {
                    writer.WriteValue(true);
                }
            }
        }

        public override bool CanConvert(Type objectType)
        {
            if(objectType == typeof(string))
            {
                return true;
            }
            else if(objectType == typeof(bool))
            {
                return true;
            }
            else if(objectType == typeof(Nullable))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
