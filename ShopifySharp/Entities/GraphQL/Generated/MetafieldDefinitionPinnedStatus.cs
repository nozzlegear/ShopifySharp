#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible metafield definition pinned statuses.
/// </summary>
public enum MetafieldDefinitionPinnedStatus
{
    ANY,
    PINNED,
    UNPINNED,
}