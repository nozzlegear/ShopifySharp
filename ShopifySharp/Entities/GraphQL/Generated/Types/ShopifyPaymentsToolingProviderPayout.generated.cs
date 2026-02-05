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
/// Relevant reference information for an alternate currency payout.
/// </summary>
public record ShopifyPaymentsToolingProviderPayout : IGraphQLObject
{
    /// <summary>
    /// The balance amount the alternate currency payout was created for.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// A timestamp for the arrival of the alternate currency payout.
    /// </summary>
    [JsonPropertyName("arrivalDate")]
    public DateTimeOffset? arrivalDate { get; set; } = null;

    /// <summary>
    /// A timestamp for the creation of the alternate currency payout.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The currency alternate currency payout was created in.
    /// </summary>
    [JsonPropertyName("currency")]
    public string? currency { get; set; } = null;

    /// <summary>
    /// The remote ID for the alternate currency payout.
    /// </summary>
    [JsonPropertyName("remoteId")]
    public string? remoteId { get; set; } = null;
}