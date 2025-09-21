#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An auto-generated type which holds one ProductFeed and a cursor during pagination.
/// </summary>
public record ProductFeedEdge : Edge<ProductFeed?>
{
}