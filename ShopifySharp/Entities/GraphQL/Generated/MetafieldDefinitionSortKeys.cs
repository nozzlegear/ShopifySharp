#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the MetafieldDefinition query.
/// </summary>
public enum MetafieldDefinitionSortKeys
{
    ID,
    NAME,
    PINNED_POSITION,
    RELEVANCE,
}