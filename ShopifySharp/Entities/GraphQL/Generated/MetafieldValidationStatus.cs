#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible metafield validation statuses.
/// </summary>
public enum MetafieldValidationStatus
{
    ANY,
    VALID,
    INVALID,
}