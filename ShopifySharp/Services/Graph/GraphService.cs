#nullable enable
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using Newtonsoft.Json;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Graph;
using ShopifySharp.Infrastructure.Serialization.Http;

namespace ShopifySharp;

/// <summary>
/// A service for using or manipulating Shopify's Graph API.
/// </summary>
public class GraphService : ShopifyService, IGraphService
{
    private const string DataPropertyName = "data";

    private readonly JsonSerializerOptions _jsonSerializerOptions;
    private readonly IHttpContentSerializer _httpContentSerializer;
    private readonly string? _apiVersion;

    public override string APIVersion => _apiVersion ?? base.APIVersion;

    internal GraphService(ShopifyApiCredentials shopifyApiCredentials, IServiceProvider serviceProvider)
        : base(shopifyApiCredentials, serviceProvider)
    {
        _apiVersion = null;
        (_jsonSerializerOptions, _httpContentSerializer) = InitializeDependencies(serviceProvider);
    }

    public GraphService(
        ShopifyApiCredentials shopifyApiCredentials,
        string? apiVersion = null,
        IShopifyDomainUtility? shopifyDomainUtility = null
    ) : base(shopifyApiCredentials, shopifyDomainUtility)
    {
        _apiVersion = apiVersion;
        (_jsonSerializerOptions, _httpContentSerializer) = InitializeDependencies(null);
    }

    public GraphService(
        string myShopifyUrl,
        string shopAccessToken,
        string? apiVersion = null
    ) : base(myShopifyUrl, shopAccessToken)
    {
        _apiVersion = apiVersion;
        (_jsonSerializerOptions, _httpContentSerializer) = InitializeDependencies(null);
    }

    public GraphService(
        string myShopifyUrl,
        string shopAccessToken,
        IShopifyDomainUtility shopifyDomainUtility
    ) : base(myShopifyUrl, shopAccessToken, shopifyDomainUtility)
    {
        _apiVersion = null;
        (_jsonSerializerOptions, _httpContentSerializer) = InitializeDependencies(null);
    }

    private static (JsonSerializerOptions, IHttpContentSerializer) InitializeDependencies(IServiceProvider? serviceProvider)
    {
        var jsonSerializerOptions = InternalServiceResolver.GetServiceOrDefault(
            serviceProvider,
            () => Serializer.GraphSerializerOptions
        );
        var httpContentSerializer = InternalServiceResolver.GetServiceOrDefault<IHttpContentSerializer>(
            serviceProvider,
            () => new GraphHttpContentSerializer(jsonSerializerOptions)
        );
        return (jsonSerializerOptions, httpContentSerializer);
    }

    public virtual async Task<GraphResult<T?>> PostAsync<T>(GraphRequest graphRequest, CancellationToken cancellationToken = default)
    {
        using var response = await SendAsync(graphRequest, cancellationToken);
        var data = response.Json.RootElement.GetProperty(DataPropertyName).Deserialize<T>(_jsonSerializerOptions);
        var extensions = ParseGraphExtensions(response.Json);

        return new GraphResult<T?>
        {
            Data = data,
            Extensions = extensions,
            RequestId = response.RequestId,
        };
    }

    // TODO: is this needed with PostAsync<GraphResult<T?>>
    // public virtual async Task<GraphResult<object>> PostAsync(GraphRequest request, Type resultType, CancellationToken cancellationToken = default)
    // {
    //     var elt = await SendAsync(request, cancellationToken);
    //     var ptyElt = elt.Json.RootElement.EnumerateObject().Single().Value;
    //     return GraphQL.Serializer.Deserialize(ptyElt.GetRawText(), resultType);
    // }

    public virtual async Task<GraphResult> PostAsync(GraphRequest graphRequest, CancellationToken cancellationToken = default)
    {
        return await SendAsync(graphRequest, cancellationToken);
    }

    #nullable disable

    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<JToken> PostAsync(JToken body, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        if (body is null)
            throw new ArgumentNullException(nameof(body));

        var query = body.SelectToken("query");

        if (query is null || query.Type != JTokenType.String)
            throw new ArgumentException($"The type of the required `query` property should be {JTokenType.String}, but it was {query?.Type ?? JTokenType.Null}", nameof(body));

        using var response = await SendAsync(new GraphRequest
        {
            Query = query.Value<string>(),
            Variables = body.SelectToken("variables")?.ToObject<Dictionary<string, object>>(),
            EstimatedQueryCost = graphqlQueryCost,
            UserErrorHandling = GraphRequestUserErrorHandling.Throw,
        }, cancellationToken);

        // This is extremely inefficient, but since the method is deprecated and will be removed, we're taking a shortcut
        return Serializer.Deserialize<JToken>(response.Json.RootElement.GetProperty(DataPropertyName).GetRawText(),
            null,
            DateParseHandling.None);
    }

    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<JToken> PostAsync(string graphqlQuery, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        using var response = await SendAsync(new GraphRequest
        {
            Query = graphqlQuery,
            Variables = null,
            EstimatedQueryCost = graphqlQueryCost,
            UserErrorHandling = GraphRequestUserErrorHandling.Throw,
        }, cancellationToken);
        // This is extremely inefficient, but since the method is deprecated and will be removed, we're taking a shortcut
        var thing = response.Json.RootElement.GetProperty(DataPropertyName);
        return Serializer.Deserialize<JToken>(thing.GetRawText(),
            null,
            DateParseHandling.None);
    }

    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<JsonElement> SendAsync(string graphqlQuery, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        using var response = await SendAsync(new GraphRequest
        {
            Query = graphqlQuery,
            Variables = null,
            EstimatedQueryCost = graphqlQueryCost,
            UserErrorHandling = GraphRequestUserErrorHandling.Throw,
        }, cancellationToken);

        return response.Json.RootElement.GetProperty(DataPropertyName).Clone();
    }

    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<JsonElement> SendAsync(GraphRequest request, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        using var response = await SendAsync(new GraphRequest
        {
            Query = request.Query,
            Variables = request.Variables,
            EstimatedQueryCost = graphqlQueryCost ?? request.EstimatedQueryCost,
            UserErrorHandling = request.UserErrorHandling
        }, cancellationToken);

        return response.Json.RootElement.GetProperty(DataPropertyName).Clone();
    }

#if NET6_0_OR_GREATER
    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<TResult> SendAsync<TResult>(string graphqlQuery, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
        where TResult : class
    {
        using var result = await SendAsync(new GraphRequest
        {
            Query = graphqlQuery,
            Variables = null,
            EstimatedQueryCost = graphqlQueryCost,
            UserErrorHandling = GraphRequestUserErrorHandling.Throw
        }, cancellationToken);

        var data = result.Json.RootElement.GetProperty(DataPropertyName);
        // This obsolete method relies specifically on this behavior of enumerating the object and selecting the first value.
        // It is expected that the method will throw if more than one property is found in the json object.
        return data.EnumerateObject().Single().Value.Deserialize<TResult>();
    }

    /// <summary>
    /// Issue a single value query and return the value as an strongly typed object.
    /// Use a type from the ShopifySharp.GraphQL namespace
    /// </summary>
    /// <typeparam name="TResult">Use a type from the ShopifySharp.GraphQL namespace</typeparam>
    /// <param name="request"></param>
    /// <param name="graphqlQueryCost"></param>
    /// <param name="cancellationToken"></param>
    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<TResult> SendAsync<TResult>(GraphRequest request, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
        where TResult : class
    {
        using var result = await SendAsync(new GraphRequest
        {
            Query = request.Query,
            Variables = request.Variables,
            EstimatedQueryCost = graphqlQueryCost ?? request.EstimatedQueryCost,
            UserErrorHandling = request.UserErrorHandling
        }, cancellationToken);

        var data = result.Json.RootElement.GetProperty(DataPropertyName);
        // This obsolete method relies specifically on this behavior of enumerating the object and selecting the first value.
        // It is expected that the method will throw if more than one property is found in the json object.
        return data.EnumerateObject().Single().Value.Deserialize<TResult>();
    }
#endif

    /// <summary>
    /// Sends a Graph request with variables to Shopify's Graph API.
    /// </summary>
    /// <param name="graphRequest"></param>
    /// <param name="cancellationToken"></param>
    protected async Task<GraphResult> SendAsync(GraphRequest graphRequest, CancellationToken cancellationToken = default)
    {
        var requestUri = BuildRequestUri("graphql.json");
        using var requestContent = _httpContentSerializer.SerializeGraphRequest(requestUri, graphRequest);
        var result = await ExecuteRequestCoreAsync(requestUri, HttpMethod.Post, requestContent, null, graphRequest.EstimatedQueryCost, cancellationToken);

        var requestId = ParseRequestIdResponseHeader(result.ResponseHeaders);
        var jsonDocument = JsonDocument.Parse(result.RawResult);

        if (graphRequest.UserErrorHandling == GraphRequestUserErrorHandling.Throw)
            ThrowIfResponseContainsErrors(jsonDocument, requestId);

        return new GraphResult
        {
            Json = jsonDocument
        };
    }

    /// <summary>
    /// Sends a Graph request with variables to Shopify's Graph API.
    /// </summary>
    /// <param name="graphRequest"></param>
    /// <param name="cancellationToken"></param>
    [Obsolete("This method is obsolete and will be removed in a future version of ShopifySharp.")]
    protected virtual async Task<T> SendAsync<T>(GraphRequest graphRequest, CancellationToken cancellationToken = default) where T: class
    {
        using var graphResult = await SendAsync(graphRequest, cancellationToken);
        return graphResult.Json.Deserialize<T>(_jsonSerializerOptions);
    }

    #nullable enable
    private bool TryParseUserErrors(JsonProperty jsonProperty, string? requestId, out ICollection<GraphUserError> userErrors)
    {
        const string userErrorsPropertyName = "userErrors";
        userErrors = [];

        if (!jsonProperty.Value.TryGetProperty(userErrorsPropertyName, out var userErrorsProperty))
            return false;

        if (userErrorsProperty.ValueKind != JsonValueKind.Array)
            throw new ShopifyJsonParseException(
                $"Failed to parse {userErrorsPropertyName} property, expected {JsonValueKind.Array} but got {userErrorsProperty.ValueKind}",
                jsonPropertyName: userErrorsPropertyName,
                requestId: requestId);

        if (userErrorsProperty.GetArrayLength() == 0)
            return false;

        userErrors = userErrorsProperty
            .Deserialize<ICollection<GraphUserError>>(_jsonSerializerOptions)?
            .ToList() ?? [];

        return userErrors.Count > 0;
    }

    /// <summary>
    /// Since Graph API Errors come back with error code 200, checking for them in a way similar to the REST API doesn't work well without potentially throwing unnecessary errors.
    /// </summary>
    /// <exception cref="ShopifyHttpException">Thrown if <paramref name="jsonDocument"/> contains any <c>userErrors</c> entries.</exception>
    private void ThrowIfResponseContainsErrors(JsonDocument jsonDocument, string? requestId)
    {
        if (!jsonDocument.RootElement.TryGetProperty(DataPropertyName, out var dataElement))
            throw new ShopifyJsonParseException(
                $"The JSON response from Shopify does not contain the expected '{DataPropertyName}' property.",
                DataPropertyName,
                requestId
            );

        foreach (var jsonProperty in dataElement.EnumerateObject())
        {
            if (jsonProperty.Value.ValueKind != JsonValueKind.Object)
                continue;

            if (!TryParseUserErrors(jsonProperty, requestId, out var userErrors))
                continue;

            throw new ShopifyGraphUserErrorsException(userErrors, requestId);
        }
    }

    protected GraphExtensions? ParseGraphExtensions(JsonDocument jsonDocument)
    {
        const string propertyName = "extensions";

        return jsonDocument.RootElement.TryGetProperty(propertyName, out var extensions)
            ? extensions.Deserialize<GraphExtensions>(_jsonSerializerOptions)
            : null;
    }

    /// <summary>
    /// Since Graph API Errors come back with error code 200, checking for them in a way similar to the REST API doesn't work well without potentially throwing unnecessary errors.
    /// </summary>
    /// <param name="requestResult">The <see cref="RequestResult{JToken}" /> response from ExecuteRequestAsync.</param>
    /// <exception cref="ShopifyException">Thrown if <paramref name="requestResult"/> contains an error.</exception>
    [Obsolete("This method is obsolete and will be removed in a future version of ShopifySharp."), ExcludeFromCodeCoverage]
    protected virtual void CheckForErrors<T>(RequestResult<T> requestResult)
    {
        var jsonDocument = JsonDocument.Parse(requestResult.RawResult);

        ThrowIfResponseContainsErrors(jsonDocument, ParseRequestIdResponseHeader(requestResult.ResponseHeaders));
    }
}
