using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace ShopifySharp.Infrastructure
{
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
            var rawData = Serializer.Serialize(data);

            return Encoding.UTF8.GetBytes(rawData);
        }

        public JsonContent Clone()
        {
            return new JsonContent(Data);
        }
    }
}
