#nullable enable
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System;
#if NET6_0_OR_GREATER
using System.Diagnostics.CodeAnalysis;
#endif
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
    private const string RootPath = "$.";

    private readonly IHttpContentSerializer _httpContentSerializer;
    private readonly IJsonSerializer _jsonSerializer;

    private readonly IShopifyApiVersion _shopifyApiVersion;
    public override string APIVersion => field ?? _shopifyApiVersion.Version;

    internal GraphService(ShopifyApiCredentials shopifyApiCredentials, IServiceProvider serviceProvider)
        : base(shopifyApiCredentials, serviceProvider)
    {
        (_httpContentSerializer, _jsonSerializer, _shopifyApiVersion) = InitializeDependencies(serviceProvider);
    }

    public GraphService(
        ShopifyApiCredentials shopifyApiCredentials,
        string? apiVersion = null,
        IShopifyDomainUtility? shopifyDomainUtility = null
    ) : base(shopifyApiCredentials, shopifyDomainUtility)
    {
        (_httpContentSerializer, _jsonSerializer, _shopifyApiVersion) = InitializeDependencies(null);
        APIVersion = apiVersion;
    }

    public GraphService(
        string myShopifyUrl,
        string shopAccessToken,
        string? apiVersion = null
    ) : base(myShopifyUrl, shopAccessToken)
    {
        (_httpContentSerializer, _jsonSerializer, _shopifyApiVersion) = InitializeDependencies(null);
        APIVersion = apiVersion;
    }

    public GraphService(
        string myShopifyUrl,
        string shopAccessToken,
        IShopifyDomainUtility shopifyDomainUtility
    ) : base(myShopifyUrl, shopAccessToken, shopifyDomainUtility)
    {
        (_httpContentSerializer, _jsonSerializer, _shopifyApiVersion) = InitializeDependencies(null);
    }

    private static (IHttpContentSerializer, IJsonSerializer, IShopifyApiVersion) InitializeDependencies(IServiceProvider? serviceProvider)
    {
        var httpContentSerializer = InternalServiceResolver.GetServiceOrDefault<IHttpContentSerializer>(
            serviceProvider,
            () => new GraphHttpContentSerializer(GetJsonSerializerOptions())
        );
        var jsonSerializer = InternalServiceResolver.GetServiceOrDefault<IJsonSerializer>(
            serviceProvider,
            () => new SystemJsonSerializer(GetJsonSerializerOptions())
        );
        var shopifyApiVersion = InternalServiceResolver.GetServiceOrDefault<IShopifyApiVersion>(
            serviceProvider,
            () => new DefaultShopifyApiVersion()
        );

        return (httpContentSerializer, jsonSerializer, shopifyApiVersion);

        System.Text.Json.JsonSerializerOptions GetJsonSerializerOptions() => InternalServiceResolver.GetServiceOrDefault(serviceProvider, () => Serializer.GraphSerializerOptions);
    }

    /// <inheritdoc/>
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

        // Smart deserialization: Try to unwrap single-property responses
        dataElement = TryUnwrapSinglePropertyResponse(dataElement, resultType);

        var data = await DeserializeJsonElementToTypeAsync(dataElement, resultType, response.RequestId, cancellationToken);

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

        using var response = await SendAsync(new GraphRequest
        {
            Query = graphRequest.Query!.Build(),
            EstimatedQueryCost = graphRequest.EstimatedQueryCost,
            UserErrorHandling = graphRequest.UserErrorHandling,
            Variables = null,
        }, cancellationToken);
        var dataElement = GetJsonDataElementOrThrow(response.Json, response.RequestId);
        var propertyKey = graphRequest.Query!.AliasName ?? graphRequest.Query.QueryName;

        try
        {
            // Select the alias name/query name, preventing the need for a "container" class to unwrap the result
            dataElement = dataElement.GetProperty(propertyKey);
        }
        catch (KeyNotFoundException exn)
        {
            var qualifiedKey = $"{DataPropertyName}.{propertyKey}";
            throw new ShopifyJsonParseException(
                $"The JSON response from Shopify does not contain the expected '{qualifiedKey}' property.",
                qualifiedKey,
                response.RequestId,
                exn);
        }

        var data = await DeserializeJsonElementToTypeAsync(dataElement, typeof(T), response.RequestId, cancellationToken);

        return new GraphResult<T>
        {
            Data = (T) data,
            Extensions = await ParseGraphExtensionsAsync(response.Json, response.RequestId, cancellationToken),
            RequestId = response.RequestId,
        };
    }

    /// <summary>
    /// Sends a Graph request with variables to Shopify's Graph API.
    /// </summary>
    /// <exception cref="ShopifyGraphErrorsException">Thrown when a non-empty <c>errors</c> collection is detected at the top level.</exception>
    /// <exception cref="ShopifyGraphUserErrorsException">Thrown when a non-empty <c>errors</c> collection is detected on any of the <c>data</c> properties.</exception>
    /// <exception cref="ShopifyJsonParseException">Thrown when the json serializer fails to parse data while checking for errors, or while parsing the json document itself.</exception>
    protected async Task<GraphResult> SendAsync(GraphRequest graphRequest, CancellationToken cancellationToken = default)
    {
        var requestUri = BuildRequestUri("graphql.json");
        using var requestContent = _httpContentSerializer.SerializeGraphRequest(requestUri, graphRequest);
        var result = await ExecuteRequestCoreAsync(requestUri, HttpMethod.Post, requestContent, null, graphRequest.EstimatedQueryCost, cancellationToken);

        var requestId = ParseRequestIdResponseHeader(result.ResponseHeaders);
        IJsonElement jsonDocument;

        try
        {
            jsonDocument = _jsonSerializer.Parse(result.RawResult);
        }
        catch (NotSupportedException exn) when (IsDeserializationTypeException(exn))
        {
            RethrowDeserializationException(exn, typeof(IJsonElement), requestId);
            throw; // Unreachable, but keeps the compiler happy
        }
        catch (Exception ex) when (ex is not ShopifyJsonParseException)
        {
            throw new ShopifyJsonParseException(
                "Failed to parse Shopify's response into a JSON document. Check the inner exception for more details.",
                jsonPropertyName: GetJsonPathOrDefault(ex, RootPath),
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
                jsonPropertyName: GetJsonPathOrDefault(exn, RootPath),
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
        userErrors = [];

        if (!TryGetNonEmptyArrayProperty(jsonProperty, userErrorsPropertyName, requestId, out var userErrorsProperty))
            return false;

        userErrors = _jsonSerializer.Deserialize<IReadOnlyList<GraphUserError>>(userErrorsProperty!) ?? [];

        return userErrors.Count > 0;
    }

    private static bool TryGetNonEmptyArrayProperty(
        IJsonElement element,
        string propertyName,
        string? requestId,
        #if NET6_0_OR_GREATER
        [NotNullWhen(true)]
        #endif
        out IJsonElement? arrayElement
    )
    {
        arrayElement = null;

        if (!element.TryGetProperty(propertyName, out var prop))
            return false;

        if (prop.ValueType != JsonValueType.Array)
            throw new ShopifyJsonParseException(
                $"Failed to parse {propertyName} property, expected {JsonValueType.Array} but got {prop.ValueType}.",
                $"{RootPath}{propertyName}",
                requestId);

        if (prop.GetArrayLength() == 0)
            return false;

        arrayElement = prop;
        return true;
    }

    private static string GetJsonPathOrDefault(Exception exn, string defaultPath) =>
        (exn as JsonException)?.Path ?? defaultPath;

    /// <summary>
    /// Attempts to unwrap single-property responses that match the target type name.
    /// This allows direct deserialization without wrapper classes for single-object queries.
    /// </summary>
    /// <param name="dataElement">The 'data' element from the GraphQL response</param>
    /// <param name="resultType">The target type for deserialization</param>
    /// <returns>Unwrapped element if single property matches type name, otherwise the original element</returns>
    private static IJsonElement TryUnwrapSinglePropertyResponse(IJsonElement dataElement, Type resultType)
    {
        // Only attempt unwrapping if data has exactly one property
        if (dataElement.GetPropertyCount() != 1)
            return dataElement;

        // Try to find a property matching the type name (case insensitive)
        if (dataElement.TryGetPropertyCaseInsensitive(resultType.Name, out var unwrappedElement))
            return unwrappedElement;

        // No match found, return original element (may be using the wrapper pattern)
        return dataElement;
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

    private static void RethrowDeserializationException(NotSupportedException exn, Type rootType, string? requestId)
    {
        var offendingPath = exn.GetOffendingPathFromMessage();
        var jsonPath = offendingPath is null or "$" ? DataPropertyName : offendingPath;
        var offendingType = exn.GetOffendingTypeFromMessage();

        if (exn.Message.StartsWithIgnoreCase("Deserialization of interface or abstract types is not supported"))
            throw new ShopifyUnsupportedTypeDeserializationException(rootType, jsonPath, offendingType, requestId, exn);

        if (exn.Message.StartsWithIgnoreCase("The JSON payload for polymorphic interface or abstract type")
            && exn.Message.ContainsIgnoreCase("must specify a type discriminator."))
            throw new ShopifyUnspecifiedTypeDiscriminatorException(rootType, jsonPath, offendingType, requestId, exn);
    }

    private static bool IsDeserializationTypeException(NotSupportedException exn) =>
        exn.Message.StartsWithIgnoreCase("Deserialization of interface or abstract types is not supported") ||
        (exn.Message.StartsWithIgnoreCase("The JSON payload for polymorphic interface or abstract type")
         && exn.Message.ContainsIgnoreCase("must specify a type discriminator."));

    private async Task<object> DeserializeJsonElementToTypeAsync(IJsonElement jsonElement, Type resultType, string? requestId, CancellationToken cancellationToken = default)
    {
        object? data;

        try
        {
            data = await _jsonSerializer.DeserializeAsync(jsonElement, resultType, cancellationToken);
        }
        catch (NotSupportedException exn) when (IsDeserializationTypeException(exn))
        {
            RethrowDeserializationException(exn, resultType, requestId);
            throw; // Unreachable, but keeps the compiler happy
        }
        catch (Exception exn) when (exn is not ShopifyJsonParseException)
        {
            throw new ShopifyJsonParseException(
                $"The json serializer threw a {exn.GetType().FullName} exception when deserializing the '{DataPropertyName}' property into a {resultType.FullName}. Check the inner exception for more details.",
                DataPropertyName,
                requestId,
                exn);
        }

        if (data is null)
        {
            throw new ShopifyJsonParseException(
                $"Failed to deserialize the '{DataPropertyName}' property into a {resultType.FullName}. The serializer returned null instead.",
                DataPropertyName,
                requestId);
        }

        return data;
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

        if (!TryGetNonEmptyArrayProperty(jsonElement, propertyName, requestId, out var jsonProperty))
            return;

        throw new ShopifyGraphErrorsException(_jsonSerializer.Deserialize<IReadOnlyList<GraphError>>(jsonProperty!) ?? [], requestId);
    }

    protected async ValueTask<GraphExtensions?> ParseGraphExtensionsAsync(
        IJsonElement jsonElement,
        string? requestId,
        CancellationToken cancellationToken = default)
    {
        const string extensionsPropertyName = "extensions";
        const string extensionsPropertyPath = $"{RootPath}{extensionsPropertyName}";

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
                jsonPropertyName: GetJsonPathOrDefault(exn, extensionsPropertyPath),
                requestId,
                exn);
        }
    }
}
