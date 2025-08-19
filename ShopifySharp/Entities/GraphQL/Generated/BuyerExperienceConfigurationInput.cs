#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields specifying the behavior of checkout for a B2B buyer.
/// </summary>
public record BuyerExperienceConfigurationInput : GraphQLInputObject<BuyerExperienceConfigurationInput>
{
    /// <summary>
    /// Whether to checkout to draft order for merchant review.
    /// </summary>
    [JsonPropertyName("checkoutToDraft")]
    public bool? checkoutToDraft { get; set; } = null;

    /// <summary>
    /// The input fields configuring the deposit a B2B buyer.
    /// </summary>
    [JsonPropertyName("deposit")]
    public DepositInput? deposit { get; set; } = null;

    /// <summary>
    /// Whether to allow customers to edit their shipping address at checkout.
    /// </summary>
    [JsonPropertyName("editableShippingAddress")]
    public bool? editableShippingAddress { get; set; } = null;

    /// <summary>
    /// Represents the merchant configured payment terms.
    /// </summary>
    [JsonPropertyName("paymentTermsTemplateId")]
    public string? paymentTermsTemplateId { get; set; } = null;
}