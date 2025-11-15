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
/// Return type for `appSubscriptionTrialExtend` mutation.
/// </summary>
public record AppSubscriptionTrialExtendPayload : IGraphQLObject
{
    /// <summary>
    /// The app subscription that had its trial extended.
    /// </summary>
    [JsonPropertyName("appSubscription")]
    public AppSubscription? appSubscription { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<AppSubscriptionTrialExtendUserError>? userErrors { get; set; } = null;
}