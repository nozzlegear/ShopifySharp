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
/// The input fields required to add a new subscription line to a contract.
/// </summary>
public record SubscriptionLineInput : GraphQLInputObject<SubscriptionLineInput>
{
    /// <summary>
    /// The price of the product.
    /// </summary>
    [JsonPropertyName("currentPrice")]
    public decimal? currentPrice { get; set; } = null;

    /// <summary>
    /// The custom attributes for this subscription line.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<AttributeInput>? customAttributes { get; set; } = null;

    /// <summary>
    /// Describes expected price changes of the subscription line over time.
    /// </summary>
    [JsonPropertyName("pricingPolicy")]
    public SubscriptionPricingPolicyInput? pricingPolicy { get; set; } = null;

    /// <summary>
    /// The ID of the product variant the subscription line refers to.
    /// </summary>
    [JsonPropertyName("productVariantId")]
    public string? productVariantId { get; set; } = null;

    /// <summary>
    /// The quantity of the product.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The selling plan for the subscription line.
    /// </summary>
    [JsonPropertyName("sellingPlanId")]
    public string? sellingPlanId { get; set; } = null;

    /// <summary>
    /// The selling plan name for the subscription line.
    /// Defaults to using the selling plan's current name when not specified.
    /// </summary>
    [JsonPropertyName("sellingPlanName")]
    public string? sellingPlanName { get; set; } = null;
}