using RestSharp;

namespace ShopifySharp
{
    public class RequestResult<T>
    {
        public IRestResponse Response { get; }
        public T Result { get; }

        public RequestResult(IRestResponse response, T result)
        {
            this.Response = response;
            this.Result = result;
        }
    }
}
