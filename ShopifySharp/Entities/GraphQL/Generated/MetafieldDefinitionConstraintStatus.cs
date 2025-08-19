#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Metafield definition constraint criteria to filter metafield definitions by.
/// </summary>
public enum MetafieldDefinitionConstraintStatus
{
    CONSTRAINED_AND_UNCONSTRAINED,
    CONSTRAINED_ONLY,
    UNCONSTRAINED_ONLY,
}