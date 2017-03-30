using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace ShopifySharp.Infrastructure
{
    public class JsonContent : ByteArrayContent
    {
        public JsonContent(object data) : base(ToBytes(data))
        {
            Headers.ContentType = new MediaTypeHeaderValue("application/json");
        }

        private static byte[] ToBytes(object data)
        {
            var rawData = JsonConvert.SerializeObject(data);

            return Encoding.UTF8.GetBytes(rawData);
        }
    }
}
