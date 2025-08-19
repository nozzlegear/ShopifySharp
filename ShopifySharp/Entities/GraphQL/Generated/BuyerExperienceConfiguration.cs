#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Settings describing the behavior of checkout for a B2B buyer.
/// </summary>
public record BuyerExperienceConfiguration : IGraphQLObject
{
    /// <summary>
    /// Whether to checkout to draft order for merchant review.
    /// </summary>
    [JsonPropertyName("checkoutToDraft")]
    public bool? checkoutToDraft { get; set; } = null;

    /// <summary>
    /// The portion required to be paid at checkout.
    /// </summary>
    [JsonPropertyName("deposit")]
    public DepositConfiguration? deposit { get; set; } = null;

    /// <summary>
    /// Whether to allow customers to use editable shipping addresses.
    /// </summary>
    [JsonPropertyName("editableShippingAddress")]
    public bool? editableShippingAddress { get; set; } = null;

    /// <summary>
    /// Represents the merchant configured payment terms.
    /// </summary>
    [JsonPropertyName("paymentTermsTemplate")]
    public PaymentTermsTemplate? paymentTermsTemplate { get; set; } = null;

    /// <summary>
    /// Whether a buyer must pay at checkout or they can also choose to pay
    /// later using net terms.
    /// </summary>
    [JsonPropertyName("payNowOnly")]
    [Obsolete("Please use `checkoutToDraft`(must be false) and `paymentTermsTemplate`(must be nil) to derive this instead.")]
    public bool? payNowOnly { get; set; } = null;
}