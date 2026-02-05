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
/// Return type for `appSubscriptionCancel` mutation.
/// </summary>
public record AppSubscriptionCancelPayload : IGraphQLObject
{
    /// <summary>
    /// The cancelled app subscription.
    /// </summary>
    [JsonPropertyName("appSubscription")]
    public AppSubscription? appSubscription { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}