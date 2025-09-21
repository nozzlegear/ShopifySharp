#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An auto-generated type for paginating through multiple CustomerAccountPages.
/// </summary>
public record CustomerAccountPageConnection : ConnectionWithNodesAndEdges<ICustomerAccountPage?>
{
}