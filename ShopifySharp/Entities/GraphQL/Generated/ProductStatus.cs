#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible product statuses.
/// </summary>
public enum ProductStatus
{
    ACTIVE,
    ARCHIVED,
    DRAFT,
}