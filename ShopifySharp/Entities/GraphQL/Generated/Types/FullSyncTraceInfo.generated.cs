#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Trace information for a single country-language product feed sync triggered by [`channelFullSync`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/channelFullSync).
/// </summary>
public record FullSyncTraceInfo : IGraphQLObject
{
    /// <summary>
    /// The country of the product feed that was triggered.
    /// </summary>
    [JsonPropertyName("country")]
    public CountryCode? country { get; set; } = null;

    /// <summary>
    /// The language of the product feed that was triggered.
    /// </summary>
    [JsonPropertyName("language")]
    public LanguageCode? language { get; set; } = null;

    /// <summary>
    /// The operation ID of a successfully initiated product full sync operation. This
    /// field is set to nil when the full sync operation isn't successfully initiated.
    /// </summary>
    [JsonPropertyName("operationId")]
    public string? operationId { get; set; } = null;
}