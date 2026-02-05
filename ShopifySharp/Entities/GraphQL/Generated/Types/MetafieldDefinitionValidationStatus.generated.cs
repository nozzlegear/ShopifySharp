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
/// Possible metafield definition validation statuses.
/// </summary>
public enum MetafieldDefinitionValidationStatus
{
    ALL_VALID,
    IN_PROGRESS,
    SOME_INVALID,
}