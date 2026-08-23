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
/// A payment mandate with resource information, representing the permission
/// the owner of the payment instrument gives to the merchant to debit it
/// for specific resources (e.g., Order, Subscriptions).
/// </summary>
public record PaymentMandateResource : IGraphQLObject
{
    /// <summary>
    /// The unique ID of the payment mandate. Matches the corresponding
    /// `CustomerPaymentMethod.id` token, so partners can identify which payment
    /// method to use for a given mandate scope (e.g., SUBSCRIPTIONS).
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The ID of the resource that this payment method was created for.
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string? resourceId { get; set; } = null;

    /// <summary>
    /// The resource type that this payment method was created for (e.g., Order, Subscriptions).
    /// </summary>
    [JsonPropertyName("resourceType")]
    public MandateResourceType? resourceType { get; set; } = null;
}