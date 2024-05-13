#nullable enable
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ShopifySharp;

public class RequestResult<T>
{
    public string? RequestInfo { get; }

    [Obsolete("This property is obsolete and will be removed in a future version of ShopifySharp. If you need to use the response headers, please use the " + nameof(ResponseHeaders) + " property instead.")]
    public HttpResponseMessage Response { get; }

    public HttpResponseHeaders ResponseHeaders { get; }

    public HttpStatusCode StatusCode { get; }

    public T Result { get; }

    public string RawResult { get; }

    /// <summary>
    /// Only exists for list requests, will be null or empty for all others.
    /// </summary>
    public string? RawLinkHeaderValue { get; }

    [Obsolete("This constructor is obsolete and will be removed in a future version of ShopifySharp.")]
    public RequestResult(HttpResponseMessage response, T result, string rawResult, string rawLinkHeaderValue)
    {
        Response = response;
        ResponseHeaders = response.Headers;
        Result = result;
        RawResult = rawResult;
        RawLinkHeaderValue = rawLinkHeaderValue;
        StatusCode = response.StatusCode;
    }

    public RequestResult(
        string requestInfo,
        HttpResponseMessage httpResponseMessage,
        HttpResponseHeaders httpResponseHeaders,
        T result,
        string rawResult,
        string rawLinkHeaderValue,
        HttpStatusCode statusCode)
    {
        RequestInfo = requestInfo;
        Response = httpResponseMessage;
        ResponseHeaders = httpResponseHeaders;
        Result = result;
        RawResult = rawResult;
        RawLinkHeaderValue = rawLinkHeaderValue;
        StatusCode = statusCode;
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
