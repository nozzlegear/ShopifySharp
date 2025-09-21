#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the state of this catalog operation.
/// </summary>
public enum ResourceOperationStatus
{
    CREATED,
    ACTIVE,
    COMPLETE,
}