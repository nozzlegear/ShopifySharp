#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An auto-generated type for paginating through multiple Products.
/// </summary>
public record ProductConnection : ConnectionWithNodesAndEdges<Product?>
{
}