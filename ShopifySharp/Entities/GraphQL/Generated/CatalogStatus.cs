#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The state of a catalog.
/// </summary>
public enum CatalogStatus
{
    ACTIVE,
    ARCHIVED,
    DRAFT,
}