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
/// An auto-generated type for paginating through multiple AbandonedCheckouts.
/// </summary>
public record AbandonedCheckoutConnection : ConnectionWithNodesAndEdges<AbandonedCheckout?>
{
}