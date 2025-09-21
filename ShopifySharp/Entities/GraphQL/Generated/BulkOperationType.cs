#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The valid values for the bulk operation's type.
/// </summary>
public enum BulkOperationType
{
    QUERY,
    MUTATION,
}