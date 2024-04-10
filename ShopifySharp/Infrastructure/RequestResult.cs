#nullable enable
using System.Net;
using System.Net.Http.Headers;

namespace ShopifySharp;

public class RequestResult<T>
{
    public string? RequestInfo { get; }

    public HttpResponseHeaders ResponseHeaders { get; }

    public HttpStatusCode StatusCode { get; }

    public T Result { get; }

    public string RawResult { get; }

    /// <summary>
    /// Only exists for list requests, will be null or empty for all others.
    /// </summary>
    public string? RawLinkHeaderValue { get; }

    public RequestResult(
        string requestInfo,
        HttpResponseHeaders httpResponseHeaders,
        T result,
        string rawResult,
        string rawLinkHeaderValue,
        HttpStatusCode statusCode)
    {
        RequestInfo = requestInfo;
        ResponseHeaders = httpResponseHeaders;
        Result = result;
        RawResult = rawResult;
        RawLinkHeaderValue = rawLinkHeaderValue;
        StatusCode = statusCode;
    }

    public RequestResult<T2> Transform<T2>(T2 content)
    {
        return new RequestResult<T2>(RequestInfo,
            ResponseHeaders,
            content,
            RawResult,
            RawLinkHeaderValue,
            StatusCode);
    }

    public RestBucketState? GetRestBucketState()
    {
        return RestBucketState.Get(ResponseHeaders);
    }

    public GraphQLBucketState? GetGraphQLBucketState(System.Text.Json.JsonDocument response)
    {
        return GraphQLBucketState.Get(response);
    }
}
