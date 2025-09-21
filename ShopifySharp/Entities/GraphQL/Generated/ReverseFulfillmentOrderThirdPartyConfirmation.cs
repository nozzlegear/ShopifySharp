#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The third-party confirmation of a reverse fulfillment order.
/// </summary>
public record ReverseFulfillmentOrderThirdPartyConfirmation : IGraphQLObject
{
    /// <summary>
    /// The status of the reverse fulfillment order third-party confirmation.
    /// </summary>
    [JsonPropertyName("status")]
    public ReverseFulfillmentOrderThirdPartyConfirmationStatus? status { get; set; } = null;
}