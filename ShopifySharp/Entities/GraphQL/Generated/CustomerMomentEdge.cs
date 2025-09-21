#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An auto-generated type which holds one CustomerMoment and a cursor during pagination.
/// </summary>
public record CustomerMomentEdge : Edge<ICustomerMoment?>
{
}