#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An auto-generated type for paginating through multiple FulfillmentEvents.
/// </summary>
public record FulfillmentEventConnection : ConnectionWithNodesAndEdges<FulfillmentEvent?>
{
}