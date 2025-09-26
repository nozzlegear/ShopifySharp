#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An auto-generated type for paginating through multiple OnlineStoreThemes.
/// </summary>
public record OnlineStoreThemeConnection : ConnectionWithNodesAndEdges<OnlineStoreTheme?>
{
}