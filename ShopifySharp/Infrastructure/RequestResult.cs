using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace ShopifySharp
{
    public class RequestResult<T>
    {
        public HttpResponseMessage Response { get; }

        public T Result { get; }

        public string RawResult { get; }
        
        /// <summary>
        /// Only exists for list requests, will be null or empty for all others. 
        /// </summary>
        public string RawLinkHeaderValue { get; }

        public RequestResult(HttpResponseMessage response, T result, string rawResult, string rawLinkHeaderValue)
        {
            this.Response = response;
            this.Result = result;
            this.RawResult = rawResult;
            this.RawLinkHeaderValue = rawLinkHeaderValue;
        }

        public RestBucketState GetRestBucketState()
        {
            return RestBucketState.Get(this.Response);
        }

        public GraphQLBucketState GetGraphQLBucketState(System.Text.Json.JsonDocument response)
        {
            return GraphQLBucketState.Get(response);
        }
    }
}
