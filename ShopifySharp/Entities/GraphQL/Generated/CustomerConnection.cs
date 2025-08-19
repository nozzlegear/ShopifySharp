#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An auto-generated type for paginating through multiple Customers.
/// </summary>
public record CustomerConnection : ConnectionWithNodesAndEdges<Customer?>
{
}