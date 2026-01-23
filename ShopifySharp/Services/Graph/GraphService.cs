#nullable enable
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Http;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.Services.Graph;
using ShopifySharp.Extensions;
using ShopifySharp.GraphQL;
using JsonException = System.Text.Json.JsonException;
using Serializer = ShopifySharp.Infrastructure.Serializer;

// ReSharper disable once CheckNamespace
namespace ShopifySharp;

/// <summary>
/// A service for using or manipulating Shopify's Graph API.
/// </summary>
public class GraphService : ShopifyService, IGraphService
{
    private const string DataPropertyName = "data";

    private readonly IHttpContentSerializer _httpContentSerializer;
    private readonly IJsonSerializer _jsonSerializer;
    private readonly string? _apiVersion;

    public override string APIVersion => _apiVersion ?? base.APIVersion;

    internal GraphService(ShopifyApiCredentials shopifyApiCredentials, IServiceProvider serviceProvider, string? apiVersion = null)
        : base(shopifyApiCredentials, serviceProvider)
    {
        _apiVersion = apiVersion;
        (_httpContentSerializer, _jsonSerializer) = InitializeDependencies(serviceProvider);
    }

    public GraphService(
        ShopifyApiCredentials shopifyApiCredentials,
        string? apiVersion = null,
        IShopifyDomainUtility? shopifyDomainUtility = null
    ) : base(shopifyApiCredentials, shopifyDomainUtility)
    {
        _apiVersion = apiVersion;
        (_httpContentSerializer, _jsonSerializer) = InitializeDependencies(null);
    }

    public GraphService(
        string myShopifyUrl,
        string shopAccessToken,
        string? apiVersion = null
    ) : base(myShopifyUrl, shopAccessToken)
    {
        _apiVersion = apiVersion;
        (_httpContentSerializer, _jsonSerializer) = InitializeDependencies(null);
    }

    public GraphService(
        string myShopifyUrl,
        string shopAccessToken,
        IShopifyDomainUtility shopifyDomainUtility
    ) : base(myShopifyUrl, shopAccessToken, shopifyDomainUtility)
    {
        _apiVersion = null;
        (_httpContentSerializer, _jsonSerializer) = InitializeDependencies(null);
    }

    private static (IHttpContentSerializer, IJsonSerializer) InitializeDependencies(IServiceProvider? serviceProvider)
    {
        var httpContentSerializer = InternalServiceResolver.GetServiceOrDefault<IHttpContentSerializer>(
            serviceProvider,
            () => new GraphHttpContentSerializer(GetJsonSerializerOptions())
        );
        var jsonSerializer = InternalServiceResolver.GetServiceOrDefault<IJsonSerializer>(
            serviceProvider,
            () => new SystemJsonSerializer(GetJsonSerializerOptions()));

        return (httpContentSerializer, jsonSerializer);

        System.Text.Json.JsonSerializerOptions GetJsonSerializerOptions() => InternalServiceResolver.GetServiceOrDefault(serviceProvider, () => Serializer.GraphSerializerOptions);
    }

    public virtual async Task<GraphResult<T>> PostAsync<T>(GraphRequest graphRequest, CancellationToken cancellationToken = default)
    {
        var returnType = typeof(T);
        var result = await PostAsync(graphRequest, returnType, cancellationToken);

        return new GraphResult<T>
        {
            Data = (T) result.Data,
            Extensions = result.Extensions,
            RequestId = result.RequestId,
        };
    }

    public virtual async Task<GraphResult<object>> PostAsync(GraphRequest graphRequest, Type resultType, CancellationToken cancellationToken = default)
    {
        using var response = await SendAsync(graphRequest, cancellationToken);
        var dataElement = GetJsonDataElementOrThrow(response.Json, response.RequestId);
        object? data;

        try
        {
            data = await _jsonSerializer.DeserializeAsync(dataElement, resultType, cancellationToken);
        }
        catch (NotSupportedException exn) when (exn.Message.StartsWithIgnoreCase("Deserialization of interface or abstract types is not supported"))
        {
            var offendingPath = exn.GetOffendingPathFromMessage();
            throw new ShopifyUnsupportedTypeDeserializationException(
                rootType: resultType,
                jsonPath: offendingPath is null or "$" ? DataPropertyName : offendingPath,
                offendingType: exn.GetOffendingTypeFromMessage(),
                requestId: response.RequestId,
                innerException: exn
            );
        }
        catch (NotSupportedException exn) when (exn.Message.StartsWithIgnoreCase("The JSON payload for polymorphic interface or abstract type") && exn.Message.ContainsIgnoreCase("must specify a type discriminator."))
        {
            var offendingPath = exn.GetOffendingPathFromMessage();
            throw new ShopifyUnspecifiedTypeDiscriminatorException(
                rootType: resultType,
                jsonPath: offendingPath is null or "$" ? DataPropertyName : offendingPath,
                offendingType: exn.GetOffendingTypeFromMessage(),
                requestId: response.RequestId,
                innerException: exn
            );
        }
        catch (Exception exn)  when (exn is not ShopifyJsonParseException)
        {
            throw new ShopifyJsonParseException(
                $"The json serializer threw a {exn.GetType().FullName} exception when deserializing the '{DataPropertyName}' property into a {resultType.FullName}. Check the inner exception for more details.",
                DataPropertyName,
                response.RequestId,
                exn);
        }

        if (data is null)
        {
            throw new ShopifyJsonParseException(
                $"Failed to deserialize the '{DataPropertyName}' property into a {resultType.FullName}. The serializer returned null instead.",
                DataPropertyName,
                response.RequestId);
        }

        return new GraphResult<object>
        {
            Data = data,
            Extensions = await ParseGraphExtensionsAsync(response.Json, response.RequestId, cancellationToken),
            RequestId = response.RequestId,
        };
    }

    public virtual async Task<GraphResult> PostAsync(GraphRequest graphRequest, CancellationToken cancellationToken = default)
    {
        return await SendAsync(graphRequest, cancellationToken);
    }

    public virtual async Task<GraphResult<T>> PostAsync<T>(GraphRequest<T> graphRequest, CancellationToken cancellationToken = default)
        where T : IGraphQLObject
    {
        RequiredArgument.NotNull(graphRequest, nameof(graphRequest));
        RequiredArgument.NotNull(graphRequest.Query, nameof(graphRequest.Query));

        return await PostAsync<T>(new GraphRequest
        {
            Query = graphRequest.Query!.Build(),
            EstimatedQueryCost = graphRequest.EstimatedQueryCost,
            UserErrorHandling = graphRequest.UserErrorHandling,
            Variables = null,
        }, cancellationToken);
    }

    /// <summary>
    /// Sends a Graph request with variables to Shopify's Graph API.
    /// </summary>
    /// <exception cref="ShopifyGraphErrorsException">Thrown when a non-empty <c>errors</c> collection is detected at the top level.</exception>
    /// <exception cref="ShopifyGraphUserErrorsException">Thrown when a non-empty <c>errors</c> collection is detected on any of the <c>data</c> properties.</exception>
    /// <exception cref="ShopifyJsonParseException">Thrown when the json serializer fails to parse data while checking for errors, or while parsing the json document itself.</exception>
    protected async Task<GraphResult> SendAsync(GraphRequest graphRequest, CancellationToken cancellationToken = default)
    {
        const string rootPath = "$.";
        var requestUri = BuildRequestUri("graphql.json");
        using var requestContent = _httpContentSerializer.SerializeGraphRequest(requestUri, graphRequest);
        var result = await ExecuteRequestCoreAsync(requestUri, HttpMethod.Post, requestContent, null, graphRequest.EstimatedQueryCost, cancellationToken);

        var requestId = ParseRequestIdResponseHeader(result.ResponseHeaders);
        IJsonElement jsonDocument;

        try
        {
            jsonDocument = _jsonSerializer.Parse(result.RawResult);
        }
        catch (NotSupportedException exn) when (exn.Message.StartsWithIgnoreCase("Deserialization of interface or abstract types is not supported"))
        {
            var offendingPath = exn.GetOffendingPathFromMessage();
            throw new ShopifyUnsupportedTypeDeserializationException(
                rootType: typeof(IJsonElement),
                jsonPath: offendingPath is null or "$" ? DataPropertyName : offendingPath,
                offendingType: exn.GetOffendingTypeFromMessage(),
                requestId: requestId,
                innerException: exn
            );
        }
        catch (NotSupportedException exn) when (exn.Message.StartsWithIgnoreCase("The JSON payload for polymorphic interface or abstract type") && exn.Message.ContainsIgnoreCase("must specify a type discriminator."))
        {
            var offendingPath = exn.GetOffendingPathFromMessage();
            throw new ShopifyUnspecifiedTypeDiscriminatorException(
                rootType: typeof(IJsonElement),
                jsonPath: offendingPath is null or "$" ? DataPropertyName : offendingPath,
                offendingType: exn.GetOffendingTypeFromMessage(),
                requestId: requestId,
                innerException: exn
            );
        }
        catch (Exception ex)  when (ex is not ShopifyJsonParseException)
        {
            throw new ShopifyJsonParseException(
                "Failed to parse Shopify's response into a JSON document. Check the inner exception for more details.",
                jsonPropertyName: (ex is JsonException jxn ? jxn.Path : null) ?? rootPath,
                requestId: requestId,
                innerException: ex);
        }

        try
        {
            // TODO: make sure this doesn't override ShopifyRateLimitException throws
            ThrowIfResponseContainsGraphRequestErrors(jsonDocument, requestId);

            if (graphRequest.UserErrorHandling == GraphRequestUserErrorHandling.Throw)
                ThrowIfResponseContainsGraphUserErrors(jsonDocument, requestId);
        }
        catch (Exception exn) when (exn is not ShopifyException)
        {
            jsonDocument.Dispose();
            throw new ShopifyJsonParseException(
                "An exception was thrown while checking the json document for errors returned by Shopify. Check the inner exception for more details.",
                jsonPropertyName: (exn is JsonException jxn ? jxn.Path : null) ?? rootPath,
                requestId: requestId,
                innerException: exn);
        }
        catch
        {
            jsonDocument.Dispose();
            throw;
        }

        return new GraphResult
        {
            Json = jsonDocument,
            RequestId = requestId
        };
    }

    private bool TryParseUserErrors(IJsonElement jsonProperty, string? requestId, out IReadOnlyList<GraphUserError> userErrors)
    {
        const string userErrorsPropertyName = "userErrors";
        const string userErrorsPropertyPath = $"$.{userErrorsPropertyName}";
        userErrors = [];

        if (!jsonProperty.TryGetProperty(userErrorsPropertyName, out var userErrorsProperty))
            return false;

        if (userErrorsProperty.ValueType != JsonValueType.Array)
            throw new ShopifyJsonParseException(
                $"Failed to parse {userErrorsPropertyName} property, expected {JsonValueType.Array} but got {userErrorsProperty.ValueType}.",
                jsonPropertyName: userErrorsPropertyPath,
                requestId: requestId);

        if (userErrorsProperty.GetArrayLength() == 0)
            return false;

        userErrors = _jsonSerializer.Deserialize<IReadOnlyList<GraphUserError>>(userErrorsProperty) ?? [];

        return userErrors.Count > 0;
    }

    /// <summary>
    /// Gets the <paramref name="jsonDocument"/>'s <c>data</c> node. Throws a <see cref="ShopifyJsonParseException"/>
    /// if the element can't be found, or if it's an invalid or unexpected type.
    /// </summary>
    /// <param name="jsonDocument">The json document returned by a request to Shopify's GraphQL API.</param>
    /// <param name="requestId">The API's request ID. This will be passed to the exception when thrown.</param>
    /// <exception cref="ShopifyJsonParseException">Thrown if the <c>data</c> element doesn't exist.</exception>
    private static IJsonElement GetJsonDataElementOrThrow(IJsonElement jsonDocument, string? requestId)
    {
        if (!jsonDocument.TryGetProperty(DataPropertyName, out var dataElement))
            throw new ShopifyJsonParseException(
                $"The JSON response from Shopify does not contain the expected '{DataPropertyName}' property.",
                DataPropertyName,
                requestId
            );

        if (dataElement.ValueType is not JsonValueType.Object)
            throw new ShopifyJsonParseException(
                $"The JSON response from Shopify contains an invalid '{DataPropertyName}' property of type '{dataElement.ValueType}', but a property of type '{JsonValueType.Object}' is required.",
                DataPropertyName,
                requestId);

        return dataElement;
    }

    /// <summary>
    /// Inspects each child property of the JsonDocument's <c>data</c> node for <c>userErrors</c>.
    /// Throws a <see cref="ShopifyGraphUserErrorsException" /> if any <c>userErrors</c> collection is not empty.
    /// </summary>
    /// <exception cref="ShopifyGraphUserErrorsException">Thrown when a non-empty <c>userErrors</c> collection is detected.</exception>
    protected void ThrowIfResponseContainsGraphUserErrors(IJsonElement jsonDocument, string? requestId)
    {
        var dataElement = GetJsonDataElementOrThrow(jsonDocument, requestId);

        foreach (var jsonProperty in dataElement.EnumerateObject())
        {
            if (jsonProperty.ValueType is not JsonValueType.Object)
                continue;

            if (!TryParseUserErrors(jsonProperty, requestId, out var userErrors))
                continue;

            throw new ShopifyGraphUserErrorsException(userErrors, requestId);
        }
    }

    /// <summary>
    /// Inspects the json element for an <c>errors</c> property. Throws a <see cref="ShopifyGraphErrorsException"/> if the property
    /// is found and it is not empty.
    /// </summary>
    /// <exception cref="ShopifyGraphErrorsException">Thrown when a non-empty <c>errors</c> property is detected.</exception>
    protected void ThrowIfResponseContainsGraphRequestErrors(IJsonElement jsonElement, string? requestId)
    {
        const string propertyName = "errors";
        const string propertyPath = $"$.{propertyName}";

        if (!jsonElement.TryGetProperty(propertyName, out var jsonProperty))
            return;

        if (jsonProperty.ValueType != JsonValueType.Array)
            throw new ShopifyJsonParseException(
                $"Failed to parse {propertyName} property, expected {JsonValueType.Array} but got {jsonProperty.ValueType}.",
                jsonPropertyName: propertyPath,
                requestId: requestId);

        if (jsonProperty.GetArrayLength() == 0)
            return;

        throw new ShopifyGraphErrorsException(_jsonSerializer.Deserialize<IReadOnlyList<GraphError>>(jsonProperty) ?? [], requestId);
    }

    protected async ValueTask<GraphExtensions?> ParseGraphExtensionsAsync(
        IJsonElement jsonElement,
        string? requestId,
        CancellationToken cancellationToken = default)
    {
        const string extensionsPropertyName = "extensions";
        const string extensionsPropertyPath = $"$.{extensionsPropertyName}";

        if (!jsonElement.TryGetProperty(extensionsPropertyName, out var extensions))
            return null;

        if (extensions.ValueType is JsonValueType.Null)
            return null;

        if (extensions.ValueType is not JsonValueType.Object)
            throw new ShopifyJsonParseException(
                $"The JSON response from Shopify contains an invalid '{extensionsPropertyName}' property of type '{extensions.ValueType}', but a property of type '{JsonValueType.Object}' is required.",
                extensionsPropertyPath,
                requestId);

        if (extensions.GetPropertyCount() == 0)
            return null;

        try
        {
            return await _jsonSerializer.DeserializeAsync<GraphExtensions>(extensions, cancellationToken);
        }
        catch (Exception exn)
        {
            throw new ShopifyJsonParseException(
                $"Failed to parse the '{extensionsPropertyName}' property into a {nameof(GraphExtensions)} object. Check the inner exception for more details.",
                jsonPropertyName: (exn is JsonException jxn ? jxn.Path : null) ?? extensionsPropertyPath,
                requestId,
                exn);
        }
    }
}
