#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A reverse shipping deliverable that may include a label and tracking information.
/// </summary>
public record ReverseDeliveryShippingDeliverable : ReverseDeliveryDeliverable, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The return label attached to the reverse delivery.
    /// </summary>
    [JsonPropertyName("label")]
    public ReverseDeliveryLabelV2? label { get; set; } = null;

    /// <summary>
    /// The information to track the reverse delivery.
    /// </summary>
    [JsonPropertyName("tracking")]
    public ReverseDeliveryTrackingV2? tracking { get; set; } = null;
}