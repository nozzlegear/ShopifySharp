#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An auto-generated type for paginating through multiple RefundShippingLines.
/// </summary>
public record RefundShippingLineConnection : ConnectionWithNodesAndEdges<RefundShippingLine?>
{
}