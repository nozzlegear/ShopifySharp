#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create a Subscription Draft.
/// </summary>
public record SubscriptionDraftInput : GraphQLInputObject<SubscriptionDraftInput>
{
    /// <summary>
    /// The billing policy for the subscription contract.
    /// </summary>
    [JsonPropertyName("billingPolicy")]
    public SubscriptionBillingPolicyInput? billingPolicy { get; set; } = null;

    /// <summary>
    /// A list of the custom attributes added to the subscription contract.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<AttributeInput>? customAttributes { get; set; } = null;

    /// <summary>
    /// The delivery method for the subscription contract.
    /// </summary>
    [JsonPropertyName("deliveryMethod")]
    public SubscriptionDeliveryMethodInput? deliveryMethod { get; set; } = null;

    /// <summary>
    /// The delivery policy for the subscription contract.
    /// </summary>
    [JsonPropertyName("deliveryPolicy")]
    public SubscriptionDeliveryPolicyInput? deliveryPolicy { get; set; } = null;

    /// <summary>
    /// The shipping price for each renewal the subscription contract.
    /// </summary>
    [JsonPropertyName("deliveryPrice")]
    public decimal? deliveryPrice { get; set; } = null;

    /// <summary>
    /// The next billing date for the subscription contract.
    /// </summary>
    [JsonPropertyName("nextBillingDate")]
    public DateTime? nextBillingDate { get; set; } = null;

    /// <summary>
    /// The note field that will be applied to the generated orders.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The ID of the payment method to be used for the subscription contract.
    /// </summary>
    [JsonPropertyName("paymentMethodId")]
    public string? paymentMethodId { get; set; } = null;

    /// <summary>
    /// The current status of the subscription contract.
    /// </summary>
    [JsonPropertyName("status")]
    public SubscriptionContractSubscriptionStatus? status { get; set; } = null;
}