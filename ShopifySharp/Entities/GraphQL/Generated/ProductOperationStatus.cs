#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the state of this product operation.
/// </summary>
public enum ProductOperationStatus
{
    CREATED,
    ACTIVE,
    COMPLETE,
}