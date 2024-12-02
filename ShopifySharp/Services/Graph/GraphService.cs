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

    #nullable enable
    private readonly JsonSerializerOptions _jsonSerializerOptions;
    private readonly IHttpContentSerializer _httpContentSerializer;
    private readonly string? _apiVersion;

    public override string APIVersion => _apiVersion ?? base.APIVersion;

    public GraphService(
        ShopifyApiCredentials shopifyApiCredentials,
        string? apiVersion,
        IDependencyContainer? dependencyContainer
    ) : base(shopifyApiCredentials, dependencyContainer)
    {
        _apiVersion = apiVersion;
        (_jsonSerializerOptions, _httpContentSerializer) = InitializeDependencies(dependencyContainer);
    }

    public GraphService(
        string myShopifyUrl,
        string shopAccessToken,
        string? apiVersion = null,
        IDependencyContainer? dependencyContainer = null
    ) : base(myShopifyUrl, shopAccessToken, null)
    {
        _apiVersion = apiVersion;
        (_jsonSerializerOptions, _httpContentSerializer) = InitializeDependencies(dependencyContainer);
    }

    [Obsolete("This constructor is deprecated and will be removed in a future version of ShopifySharp.")]
    public GraphService(
        string myShopifyUrl,
        string shopAccessToken,
        IShopifyDomainUtility shopifyDomainUtility
    ) : base(myShopifyUrl, shopAccessToken, shopifyDomainUtility)
    {
        (_jsonSerializerOptions, _httpContentSerializer) = InitializeDependencies(null);
    }

    private static (JsonSerializerOptions, IHttpContentSerializer) InitializeDependencies(IDependencyContainer? dependencyContainer)
    {
        var jsonSerializerOptions = InternalDependencyContainerConsolidation.GetServiceOrDefault(
            dependencyContainer,
            () => Serializer.GraphSerializerOptions
        );
        var httpContentSerializer = InternalDependencyContainerConsolidation.GetServiceOrDefault<IHttpContentSerializer>(
            dependencyContainer,
            () => new GraphHttpContentSerializer(jsonSerializerOptions)
        );
        return (jsonSerializerOptions, httpContentSerializer);
    }

    #nullable disable

    public virtual async Task<T> PostAsync<T>(GraphRequest graphRequest, CancellationToken cancellationToken = default)
    {
        var response = await SendAsync<JsonDocument>(graphRequest, cancellationToken);
        // TODO: return a GraphResult<T>
        return response.RootElement.GetProperty(DataPropertyName).Deserialize<T>(_jsonSerializerOptions);
    }

    public virtual async Task<JsonDocument> PostAsync(GraphRequest graphRequest, CancellationToken cancellationToken = default)
    {
        return await PostAsync<JsonDocument>(graphRequest, cancellationToken);
    }

    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<JToken> PostAsync(JToken body, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        if (body is null)
            throw new ArgumentNullException(nameof(body));

        var query = body.SelectToken("query");

        if (query is null || query.Type != JTokenType.String)
            throw new ArgumentException($"The type of the required `query` property should be {JTokenType.String}, but it was {query?.Type ?? JTokenType.Null}", nameof(body));

        var response = await SendAsync<JsonDocument>(new GraphRequest
        {
            Query = query.Value<string>(),
            Variables = body.SelectToken("variables")?.ToObject<Dictionary<string, object>>(),
            EstimatedQueryCost = graphqlQueryCost
        }, cancellationToken);

        // This is extremely inefficient, but since the method is deprecated and will be removed, we're taking a shortcut
        return Serializer.Deserialize<JToken>(response.RootElement.GetProperty(DataPropertyName).GetRawText(),
            null,
            DateParseHandling.None);
    }

    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<JToken> PostAsync(string graphqlQuery, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        var response = await SendAsync<JsonDocument>(new GraphRequest
        {
            Query = graphqlQuery,
            Variables = null,
            EstimatedQueryCost = graphqlQueryCost
        }, cancellationToken);
        // This is extremely inefficient, but since the method is deprecated and will be removed, we're taking a shortcut
        var thing = response.RootElement.GetProperty(DataPropertyName);
        return Serializer.Deserialize<JToken>(thing.GetRawText(),
            null,
            DateParseHandling.None);
    }

    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<JsonElement> SendAsync(string graphqlQuery, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        var response = await SendAsync<JsonDocument>(new GraphRequest
        {
            Query = graphqlQuery,
            Variables = null,
            EstimatedQueryCost = graphqlQueryCost,
        }, cancellationToken);

        return response.RootElement.GetProperty(DataPropertyName);
    }

    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<JsonElement> SendAsync(GraphRequest request, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        var response = await SendAsync<JsonDocument>(new GraphRequest
        {
            Query = request.Query,
            Variables = request.Variables,
            EstimatedQueryCost = graphqlQueryCost ?? request.EstimatedQueryCost,
        }, cancellationToken);

        return response.RootElement.GetProperty(DataPropertyName);
    }

#if NET6_0_OR_GREATER
    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    public virtual async Task<TResult> SendAsync<TResult>(string graphqlQuery, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
        where TResult : class
    {
        var result = await SendAsync<JsonDocument>(new GraphRequest
        {
            Query = graphqlQuery,
            Variables = null,
            EstimatedQueryCost = graphqlQueryCost,
            UserErrorHandling = GraphRequestUserErrorHandling.Throw
        }, cancellationToken);

        var data = result.RootElement.GetProperty(DataPropertyName);
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
        var result = await SendAsync<JsonDocument>(new GraphRequest
        {
            Query = request.Query,
            Variables = request.Variables,
            EstimatedQueryCost = graphqlQueryCost ?? request.EstimatedQueryCost,
            UserErrorHandling = GraphRequestUserErrorHandling.Throw
        }, cancellationToken);

        var data = result.RootElement.GetProperty(DataPropertyName);
        // This obsolete method relies specifically on this behavior of enumerating the object and selecting the first value.
        // It is expected that the method will throw if more than one property is found in the json object.
        return data.EnumerateObject().Single().Value.Deserialize<TResult>();
    }

    public virtual Task<object> PostAsync(string graphqlQuery, Type resultType, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        return PostAsync(new GraphRequest { query = graphqlQuery }, resultType, graphqlQueryCost, cancellationToken);
    }

    public virtual async Task<object> PostAsync(GraphRequest request, Type resultType, int? graphqlQueryCost = null, CancellationToken cancellationToken = default)
    {
        var elt = await this.SendAsync(request, graphqlQueryCost, cancellationToken);
        var ptyElt = elt.EnumerateObject().Single().Value;
        return GraphQL.Serializer.Deserialize(ptyElt.GetRawText(), resultType);
    }
#endif

    /// <summary>
    /// Sends a Graph request with variables to Shopify's Graph API.
    /// </summary>
    /// <param name="graphRequest"></param>
    /// <param name="cancellationToken"></param>
    protected virtual async Task<T> SendAsync<T>(GraphRequest graphRequest, CancellationToken cancellationToken = default) where T: class
    {
        var requestUri = BuildRequestUri("graphql.json");
        using var requestContent = _httpContentSerializer.SerializeGraphRequest(requestUri, graphRequest);
        var result = await ExecuteRequestCoreAsync(requestUri, HttpMethod.Post, requestContent, null, graphRequest.EstimatedQueryCost, cancellationToken);

        using var jsonDocument = JsonDocument.Parse(result.RawResult);

        if (graphRequest.UserErrorHandling == GraphRequestUserErrorHandling.Throw)
            ThrowIfResponseContainsErrors(jsonDocument, result);

        return jsonDocument.Deserialize<T>(_jsonSerializerOptions);
    }

    private bool TryParseUserErrors(JsonProperty jsonProperty, out ICollection<GraphUserError> userErrors)
    {
        const string userErrorsPropertyName = "userErrors";
        userErrors = [];

        if (!jsonProperty.Value.TryGetProperty(userErrorsPropertyName, out var userErrorsProperty))
            return false;

        if (userErrorsProperty.ValueKind != JsonValueKind.Array)
            throw new ShopifyJsonParseException(
                $"Failed to parse {userErrorsPropertyName} property, expected {JsonValueKind.Array} but got {userErrorsProperty.ValueKind}",
                userErrorsPropertyName);

        if (userErrorsProperty.GetArrayLength() == 0)
            return false;

        userErrors = userErrorsProperty
            .Deserialize<ICollection<GraphUserError>>(_jsonSerializerOptions)
            .ToList();

        return userErrors.Count > 0;
    }

    /// <summary>
    /// Since Graph API Errors come back with error code 200, checking for them in a way similar to the REST API doesn't work well without potentially throwing unnecessary errors.
    /// </summary>
    /// <exception cref="ShopifyHttpException">Thrown if <paramref name="jsonDocument"/> contains any <c>userErrors</c> entries.</exception>
    private void ThrowIfResponseContainsErrors<T>(JsonDocument jsonDocument, RequestResult<T> requestResult)
    {
        if (!jsonDocument.RootElement.TryGetProperty(DataPropertyName, out var dataElement))
            throw new ShopifyJsonParseException(
                $"The JSON response from Shopify does not contain the expected '{DataPropertyName}' property.",
                DataPropertyName);

        foreach (var jsonProperty in dataElement.EnumerateObject())
        {
            if (jsonProperty.Value.ValueKind != JsonValueKind.Object)
                continue;

            if (!TryParseUserErrors(jsonProperty, out var userErrors))
                continue;

            var requestId = ParseRequestIdResponseHeader(requestResult.ResponseHeaders);

            throw new ShopifyGraphUserErrorsException(userErrors, requestId);
        }
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

        ThrowIfResponseContainsErrors(jsonDocument, requestResult);
    }
}
