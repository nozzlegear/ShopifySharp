#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An auto-generated type for paginating through multiple ResourcePublications.
/// </summary>
public record ResourcePublicationConnection : ConnectionWithNodesAndEdges<ResourcePublication?>
{
}