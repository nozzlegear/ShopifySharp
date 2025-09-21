#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible metafield definition validation statuses.
/// </summary>
public enum MetafieldDefinitionValidationStatus
{
    ALL_VALID,
    IN_PROGRESS,
    SOME_INVALID,
}