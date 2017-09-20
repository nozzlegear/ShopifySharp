using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System;

namespace ShopifySharp.Infrastructure
{
    public interface ICloneable<T>
    {
        T Clone();
    }

    public class JsonContent : ByteArrayContent
    {
        private object Data { get; set; }

        public JsonContent(object data) : base(ToBytes(data))
        {
            Data = data;
            Headers.ContentType = new MediaTypeHeaderValue("application/json");
        }

        private static byte[] ToBytes(object data)
        {
            var rawData = JsonConvert.SerializeObject(data, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            return Encoding.UTF8.GetBytes(rawData);
        }

        public JsonContent Clone()
        {
            return new JsonContent(Data);
        }
    }
}
