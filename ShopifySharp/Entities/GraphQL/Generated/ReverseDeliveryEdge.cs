#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record ReverseDeliveryDeliverableReverseDeliveryShippingDeliverable(ReverseDeliveryShippingDeliverable Value): ReverseDeliveryDeliverable;
#endif /// <summary>

/// An auto-generated type which holds one ReverseDelivery and a cursor during pagination.
/// </summary>
public record ReverseDeliveryEdge : Edge<ReverseDelivery?>
{
}