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
/// An auto-generated type which holds one CollectionConditionsSource and a cursor during pagination.
/// </summary>
public record CollectionConditionsSourceEdge : Edge<CollectionConditionsSource?>
{
}