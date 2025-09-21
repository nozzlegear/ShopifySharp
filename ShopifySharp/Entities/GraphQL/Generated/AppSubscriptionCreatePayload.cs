#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `appSubscriptionCreate` mutation.
/// </summary>
public record AppSubscriptionCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The newly-created app subscription.
    /// </summary>
    [JsonPropertyName("appSubscription")]
    public AppSubscription? appSubscription { get; set; } = null;

    /// <summary>
    /// The URL pointing to the page where the merchant approves or declines the charges for an app subscription.
    /// </summary>
    [JsonPropertyName("confirmationUrl")]
    public string? confirmationUrl { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}