using RestSharp;

namespace ShopifySharp
{
    public class RequestResult<T>
    {
        public IRestRequest Request { get; }
        public IRestResponse Response { get; }
        public T Result { get; }

        public RequestResult(IRestRequest request, IRestResponse response, T result)
        {
            this.Request = request;
            this.Response = response;
            this.Result = result;
        }
    }
}
