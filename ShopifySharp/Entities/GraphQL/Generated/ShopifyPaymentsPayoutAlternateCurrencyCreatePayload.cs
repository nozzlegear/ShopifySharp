#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `shopifyPaymentsPayoutAlternateCurrencyCreate` mutation.
/// </summary>
public record ShopifyPaymentsPayoutAlternateCurrencyCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The resulting alternate currency payout created.
    /// </summary>
    [JsonPropertyName("payout")]
    public ShopifyPaymentsToolingProviderPayout? payout { get; set; } = null;

    /// <summary>
    /// Whether the alternate currency payout was created successfully.
    /// </summary>
    [JsonPropertyName("success")]
    public bool? success { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ShopifyPaymentsPayoutAlternateCurrencyCreateUserError>? userErrors { get; set; } = null;
}