#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `appSubscriptionLineItemUpdate` mutation.
/// </summary>
public record AppSubscriptionLineItemUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated app subscription.
    /// </summary>
    [JsonPropertyName("appSubscription")]
    public AppSubscription? appSubscription { get; set; } = null;

    /// <summary>
    /// The URL where the merchant approves or declines the updated app subscription line item.
    /// </summary>
    [JsonPropertyName("confirmationUrl")]
    public string? confirmationUrl { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}