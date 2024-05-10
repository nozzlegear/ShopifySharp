// ReSharper disable InconsistentNaming
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ShopifySharp.Infrastructure;
using Newtonsoft.Json;
using System.Threading;
using ShopifySharp.Credentials;
using ShopifySharp.Lists;
using ShopifySharp.Filters;
using ShopifySharp.Utilities;

namespace ShopifySharp;

public abstract class ShopifyService : IShopifyService
{
    public const string REQUEST_HEADER_ACCESS_TOKEN = "X-Shopify-Access-Token";

#nullable enable

    public virtual string APIVersion => "2024-04";
    public virtual bool SupportsAPIVersioning => true;

    protected Uri _ShopUri { get; set; }
    protected string _AccessToken { get; set; }

    private static IRequestExecutionPolicy _GlobalExecutionPolicy = new DefaultRequestExecutionPolicy();
    private static IHttpClientFactory _HttpClientFactory = new InternalHttpClientFactory();
    private IRequestExecutionPolicy _ExecutionPolicy;
    private HttpClient _Client;

    protected ShopifyService(string shopDomain, string accessToken, IShopifyDomainUtility domainUtility)
    {
        _ShopUri = domainUtility.BuildShopDomainUri(shopDomain);
        _AccessToken = accessToken;
        _Client = _HttpClientFactory.CreateClient();
        _ExecutionPolicy = _GlobalExecutionPolicy;
    }

    /// <summary>
    /// Creates a new instance of the service using a Shopify shop domain and access token.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    protected ShopifyService(string myShopifyUrl, string shopAccessToken)
    {
        var domainUtility = new ShopifyDomainUtility();
        _ShopUri = domainUtility.BuildShopDomainUri(myShopifyUrl);
        _AccessToken = shopAccessToken;
        _Client = _HttpClientFactory.CreateClient();
        _ExecutionPolicy = _GlobalExecutionPolicy;
    }

    /// <summary>
    /// Creates a new instance of the service using the Shopify shop domain and access token in the <paramref name="credentials"/>.
    /// </summary>
    protected ShopifyService(ShopifyApiCredentials credentials)
    {
        var domainUtility = new ShopifyDomainUtility();
        _ShopUri = domainUtility.BuildShopDomainUri(credentials.ShopDomain);
        _AccessToken = credentials.AccessToken;
        _Client = _HttpClientFactory.CreateClient();
        _ExecutionPolicy = _GlobalExecutionPolicy;
    }

    /// <summary>
    /// Attempts to build a shop API <see cref="Uri"/> for the given shop.
    /// </summary>
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="withAdminPath">Whether the <c>/admin</c> path should be included in the resulting URI.</param>
    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp. Please use the ShopifySharp.Utilities.ShopifyDomainUtility instead.")]
    // TODO: remove this method after 6-8 weeks
    public static Uri BuildShopUri(string shopDomain, bool withAdminPath)
    {
        var domainUtility = new ShopifyDomainUtility();
        var shopUri = domainUtility.BuildShopDomainUri(shopDomain);

        if (!withAdminPath)
            return shopUri;

        var uriBuilder = new UriBuilder(shopUri)
        {
            Path = "admin"
        };

        return uriBuilder.Uri;
    }

#nullable disable

    /// <summary>
    /// Sets the execution policy for this instance only. This policy will always be used over the global execution policy.
    /// This instance will revert back to the global execution policy if you pass null to this method.
    /// </summary>
    public void SetExecutionPolicy(IRequestExecutionPolicy executionPolicy)
    {
        // If the user passes null, revert to the global execution policy.
        _ExecutionPolicy = executionPolicy ?? _GlobalExecutionPolicy;
    }

    /// <summary>
    /// Sets the global execution policy for all *new* instances. Current instances are unaffected, but you can call .SetExecutionPolicy on them.
    /// The execution policy will revert back to the <see cref="DefaultRequestExecutionPolicy" /> if you pass null to this method.
    /// </summary>
    public static void SetGlobalExecutionPolicy(IRequestExecutionPolicy globalExecutionPolicy)
    {
        _GlobalExecutionPolicy = globalExecutionPolicy ?? new DefaultRequestExecutionPolicy();
    }

    /// <summary>
    /// Sets the <see cref="HttpClient" /> for this instance only. This client will always be used over the one from the global <see cref="IHttpClientFactory" />.
    /// This instance will revert back to the global execution policy if you pass null to this method.
    /// </summary>
    public void SetHttpClient(HttpClient client)
    {
        // If the user passes null, revert to the client factory's client.
        _Client = client ?? _HttpClientFactory.CreateClient();
    }

    /// <summary>
    /// Sets the global <see cref="IHttpClientFactory" /> for all *new* instances. Current instances are unaffected, but you can call <see cref="SetHttpClient(HttpClient)" /> on them.
    /// The factory will revert back to the <see cref="DefaultHttpClientFactory" /> if you pass null to this method.
    /// </summary>
    public static void SetGlobalHttpClientFactory(IHttpClientFactory factory)
    {
        _HttpClientFactory = factory ?? new InternalHttpClientFactory();
    }

    /// <summary>
    /// Builds a <see cref="RequestUri"/> by merging the <see cref="_ShopUri"/> with Shopify's admin path and the <paramref name="path"/> parameter.
    /// </summary>
    /// <param name="path">
    /// The request's path, which will be added to <c>/admin/api</c> or /admin/api/<see cref="APIVersion"/> if the service supports API versioning.
    /// </param>
    protected virtual RequestUri BuildRequestUri(string path)
    {
        var ub = new UriBuilder(_ShopUri)
        {
            Scheme = Uri.UriSchemeHttps,
            Port = 443,
            Path = SupportsAPIVersioning ? $"admin/api/{APIVersion}/{path}" : $"admin/{path}"
        };

        return new RequestUri(ub.Uri);
    }

    [Obsolete("This method is deprecated and has been replaced by BuildAdminRequestUri(string, bool).")]
    protected RequestUri PrepareRequest(string path) =>
        BuildRequestUri(path);

    /// <summary>
    /// Prepares a request to the path and appends the shop's access token header if applicable.
    /// </summary>
    protected CloneableRequestMessage PrepareRequestMessage(RequestUri uri, HttpMethod method, HttpContent content, IDictionary<string, string> headers = null)
    {
        var msg = new CloneableRequestMessage(uri.ToUri(), method, content);

        if (!string.IsNullOrEmpty(_AccessToken))
        {
            msg.Headers.Add(REQUEST_HEADER_ACCESS_TOKEN, _AccessToken);
        }

        msg.Headers.Add("Accept", "application/json");

        if (headers != null)
        {
            foreach (var kv in headers)
            {
                msg.Headers.Add(kv.Key, kv.Value);
            }
        }

        return msg;
    }

    /// <summary>
    /// Attempts to parse the Link header from a web response. Returns either the header value or null if it does not exist.
    /// </summary>
    /// <remarks>
    /// The Link header only exists on list requests.
    /// </remarks>
    private string ReadLinkHeader(HttpResponseHeaders responseHeaders)
    {
        var linkHeaderValues = responseHeaders
            .FirstOrDefault(h => h.Key.Equals("link", StringComparison.OrdinalIgnoreCase))
            .Value;

        return linkHeaderValues == null ? null : string.Join(", ", linkHeaderValues);
    }

    protected async Task<RequestResult<T>> ExecuteRequestCoreAsync<T>(
        RequestUri uri,
        HttpMethod method,
        CancellationToken cancellationToken,
        HttpContent content,
        Dictionary<string, string> headers,
        string rootElement,
        int? graphqlQueryCost,
        DateParseHandling? dateParseHandlingOverride = null
    )
    {
        using var baseRequestMessage = PrepareRequestMessage(uri, method, content, headers);
        var policyResult = await _ExecutionPolicy.Run(baseRequestMessage, async (requestMessage) =>
        {
            using var response = await _Client.SendAsync(requestMessage, cancellationToken);

#if NETSTANDARD2_0
                var rawResult = await response.Content.ReadAsStringAsync();
#else
            var rawResult = await response.Content.ReadAsStringAsync(cancellationToken);
#endif

            //Check for and throw exception when necessary.
            CheckResponseExceptions(await baseRequestMessage.GetRequestInfo(), response, rawResult);

            var result = method == HttpMethod.Delete ? default : Serializer.Deserialize<T>(rawResult, rootElement, dateParseHandlingOverride);

            return new RequestResult<T>(await baseRequestMessage.GetRequestInfo(),
                response,
                response.Headers,
                result,
                rawResult,
                ReadLinkHeader(response.Headers),
                response.StatusCode);
        }, cancellationToken, graphqlQueryCost);

        return policyResult;
    }

    /// <summary>
    /// Executes a request and returns a JToken for querying. Throws an exception when the response is invalid.
    /// Use this method when the expected response is a single line or simple object that doesn't warrant its own class.
    /// </summary>
    protected async Task<RequestResult<JToken>> ExecuteRequestAsync(
        RequestUri uri,
        HttpMethod method,
        CancellationToken cancellationToken,
        HttpContent content = null,
        Dictionary<string, string> headers = null
    )
    {
        return await ExecuteRequestCoreAsync<JToken>(uri, method, cancellationToken, content, headers, null, null);
    }

    /// <summary>
    /// Executes a request and returns the given type. Throws an exception when the response is invalid.
    /// Use this method when the expected response is a single line or simple object that doesn't warrant its own class.
    /// </summary>
    protected async Task<RequestResult<T>> ExecuteRequestAsync<T>(
        RequestUri uri,
        HttpMethod method,
        CancellationToken cancellationToken,
        HttpContent content = null,
        string rootElement = null,
        Dictionary<string, string> headers = null
    )
    {
        return await ExecuteRequestCoreAsync<T>(uri, method, cancellationToken, content, headers, rootElement, null);
    }

    private async Task<T> ExecuteWithContentCoreAsync<T>(
        string path,
        string resultRootElt,
        HttpMethod method,
        HttpContent content,
        CancellationToken cancellationToken
    )
    {
        var requestUri = BuildRequestUri(path);
        var response = await ExecuteRequestAsync<T>(requestUri, method, cancellationToken: cancellationToken, content: content, rootElement: resultRootElt);
        return response.Result;
    }

    protected async Task<T> ExecutePostAsync<T>(
        string path,
        string resultRootElt,
        CancellationToken cancellationToken,
        object jsonContent = null
    )
    {
        return await ExecuteWithContentCoreAsync<T>(path, resultRootElt, HttpMethod.Post, jsonContent == null ? null : new JsonContent(jsonContent), cancellationToken);
    }

    protected async Task<T> ExecutePutAsync<T>(
        string path,
        string resultRootElt,
        CancellationToken cancellationToken,
        object jsonContent = null
    )
    {
        return await ExecuteWithContentCoreAsync<T>(path, resultRootElt, HttpMethod.Put, jsonContent == null ? null : new JsonContent(jsonContent), cancellationToken);
    }

    protected async Task ExecuteDeleteAsync(
        string path,
        CancellationToken cancellationToken
    )
    {
        await ExecuteWithContentCoreAsync<JToken>(path, null, HttpMethod.Delete, null, cancellationToken);
    }

    private async Task<RequestResult<T>> ExecuteGetCoreAsync<T>(
        string path,
        string resultRootElt,
        Parameterizable queryParams,
        string fields,
        Dictionary<string, string> headers,
        CancellationToken cancellationToken
    )
    {
        var requestUri = BuildRequestUri(path);

        if (queryParams != null)
        {
            requestUri.QueryParams.AddRange(queryParams.ToQueryParameters());
        }

        if (!string.IsNullOrEmpty(fields))
        {
            requestUri.QueryParams.Add("fields", fields);
        }

        return await ExecuteRequestAsync<T>(requestUri, HttpMethod.Get, cancellationToken: cancellationToken, rootElement: resultRootElt, headers: headers);
    }

    protected async Task<T> ExecuteGetAsync<T>(
        string path,
        string resultRootElt,
        string fields,
        CancellationToken cancellationToken = default,
        Dictionary<string, string> headers = null
    )
    {
        return (await ExecuteGetCoreAsync<T>(path, resultRootElt, null, fields, headers, cancellationToken)).Result;
    }

    protected async Task<T> ExecuteGetAsync<T>(
        string path,
        string resultRootElt,
        Parameterizable queryParams = null,
        CancellationToken cancellationToken = default,
        Dictionary<string, string> headers = null
    )
    {
        return (await ExecuteGetCoreAsync<T>(path, resultRootElt, queryParams, null, headers, cancellationToken)).Result;
    }

    protected async Task<ListResult<T>> ExecuteGetListAsync<T>(
        string path,
        string resultRootElt,
        ListFilter<T> filter,
        CancellationToken cancellationToken = default,
        Dictionary<string, string> headers = null
    )
    {
        var result = await ExecuteGetCoreAsync<List<T>>(path, resultRootElt, filter, null, headers, cancellationToken);
        return ParseLinkHeaderToListResult(result);
    }

    /// <summary>
    /// Checks a response for exceptions or invalid status codes. Throws an exception when necessary.
    /// </summary>
    /// <param name="response">The response.</param>
    /// <param name="rawResponse">The response body returned by Shopify.</param>
    public static void CheckResponseExceptions(string requestInfo, HttpResponseMessage response, string rawResponse)
    {
        // TODO: make this method protected virtual so inheriting members can override it (e.g. the PartnerService which is doing its own custom error checking right now)

        var statusCode = (int)response.StatusCode;

        // No error if response was between 200 and 300.
        if (statusCode is >= 200 and < 300)
        {
            return;
        }

        var code = response.StatusCode;
        var statusMessage = $"{(int)code} {response.ReasonPhrase}";
        var requestId = ParseRequestIdResponseHeader(response.Headers);

        // If the error was caused by reaching the API rate limit, throw a rate limit exception.
        if ((int)code == 429 /* Too many requests */)
        {
            string rateExceptionMessage;
            IEnumerable<string> errors;

            if (TryParseErrorJson(rawResponse, out var rateLimitErrors))
            {
                rateExceptionMessage = $"({statusMessage}) {rateLimitErrors.First()}";
                errors = rateLimitErrors;
            }
            else
            {
                const string baseMessage = "Exceeded the rate limit for api client. Reduce request rates to resume uninterrupted service.";
                rateExceptionMessage = $"({statusMessage}) {baseMessage}";
                errors = new List<string> { baseMessage };
            }

            var reason = response.Headers.Contains(RestBucketState.RESPONSE_HEADER_API_CALL_LIMIT)
                ? ShopifyRateLimitReason.Other
                : ShopifyRateLimitReason.BucketFull;
            var strRetryAfter = response.Headers
                .FirstOrDefault(kvp => kvp.Key == "Retry-After")
                .Value
                ?.FirstOrDefault();
            int? retryAfterSeconds = null;

            if (int.TryParse(strRetryAfter, out var retryValue))
            {
                retryAfterSeconds = retryValue;
            }

            throw new ShopifyRateLimitException(requestInfo, code, errors.ToList(), rateExceptionMessage, rawResponse, requestId, reason, retryAfterSeconds);
        }

        var contentType = response.Content.Headers.GetValues("Content-Type").FirstOrDefault();

        // TODO: there's probably a better way to check if the content type is json
        if (contentType.StartsWithIgnoreCase("application/json") || contentType.StartsWithIgnoreCase("text/json"))
        {
            IEnumerable<string> errors;
            string exceptionMessage;

            if (TryParseErrorJson(rawResponse, out var parsedErrors))
            {
                var firstError = parsedErrors.First();
                var totalErrors = parsedErrors.Count();
                var baseErrorMessage = $"({statusMessage}) {firstError}";

                switch (totalErrors)
                {
                    case 1:
                        exceptionMessage = baseErrorMessage;
                        break;

                    case 2:
                        exceptionMessage = $"{baseErrorMessage} (and one other error)";
                        break;

                    default:
                        exceptionMessage = $"{baseErrorMessage} (and {totalErrors} other errors)";
                        break;
                }

                errors = parsedErrors;
            }
            else
            {
                exceptionMessage = $"({statusMessage}) Shopify returned {statusMessage}, but ShopifySharp was unable to parse the response JSON.";
                errors = [];
            }

            throw new ShopifyHttpException(requestInfo, code, errors.ToList(), exceptionMessage, rawResponse, requestId);
        }

        var message = $"({statusMessage}) Shopify returned {statusMessage}, but there was no JSON to parse into an error message.";
        var customErrors = new List<string>
        {
            message
        };

        throw new ShopifyHttpException(requestInfo, code, customErrors, message, rawResponse, requestId);
    }

    /// <summary>
    /// Attempts to parse a JSON string for Shopify API errors. Returns false if the string cannot be parsed or contains no errors.
    /// </summary>
    public static bool TryParseErrorJson(string json, out List<string> output)
    {
        // TODO: obsolete and replace this with a json error parsing util?
        output = null;

        if (string.IsNullOrEmpty(json))
        {
            return false;
        }

        var errors = new List<string>();

        try
        {
            var parsed = JToken.Parse(string.IsNullOrEmpty(json) ? "{}" : json);

            if (parsed.Type != JTokenType.Object)
            {
                return false;
            }

            // Errors can be any of the following:
            // 1. { "errors": "some error message"}
            // 2. { "errors": { "order" : "some error message" } }
            // 3. { "errors": { "order" : [ "some error message" ] } }
            // 4. { "error": "invalid_request", error_description:"The authorization code was not found or was already used" }
            // 5. { "error": "location_id must be specified when creating fulfillments." }

            if (parsed.Any(p => p.Path == "error") && parsed.Any(p => p.Path == "error_description"))
            {
                // Error is type #4
                var description = parsed["error_description"].Value<string>();
                var errorType = parsed["error"].Value<string>();

                errors.Add($"{errorType}: {description}");
            }
            else if (parsed.Any(p => p.Path == "error"))
            {
                // Error is type #5
                var description = parsed["error"].Value<string>();

                errors.Add(description);
            }
            else if (parsed.Any(x => x.Path == "errors"))
            {
                var parsedErrors = parsed["errors"];

                // errors can be either a single string, or an array of other errors
                if (parsedErrors?.Type == JTokenType.String)
                {
                    // errors is type #1
                    var description = parsedErrors.Value<string>();

                    errors.Add(description);
                }
                else
                {
                    // errors is type #2 or #3
                    foreach (var val in parsedErrors?.Values() ?? JEnumerable<JToken>.Empty)
                    {
                        var name = val.Path.Split('.').Last();

                        if (val.Type == JTokenType.String)
                        {
                            var description = val.Value<string>();

                            errors.Add($"{name}: {description}");
                        }
                        else if (val.Type == JTokenType.Array)
                        {
                            foreach (var msg in val.Values<string>())
                            {
                                errors.Add($"{name}: {msg}");
                            }
                        }
                    }
                }
            }
            else
            {
                return false;
            }
        }
        catch (JsonReaderException)
        {
            return false;
        }

        if (!errors.Any())
        {
            return false;
        }

        output = errors;

        return true;
    }

    /// <summary>
    /// Parses a link header value into a <see cref="ShopifySharp.Lists.ListResult{T}"/>. The Items property will need to be manually set.
    /// </summary>
    protected ListResult<T> ParseLinkHeaderToListResult<T>(RequestResult<List<T>> requestResult)
    {
        return new ListResult<T>(requestResult.Result, requestResult.RawLinkHeaderValue == null ? null : LinkHeaderParser.Parse<T>(requestResult.RawLinkHeaderValue));
    }

#nullable enable
    protected static string? ParseRequestIdResponseHeader(HttpResponseHeaders responseHeaders)
    {
        const string headerName = "X-Request-Id";
        return responseHeaders.TryGetValues(headerName, out var headerValues) ? headerValues.First() : null;
    }
}
