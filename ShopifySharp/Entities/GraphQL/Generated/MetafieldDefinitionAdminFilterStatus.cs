#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible filter statuses associated with a metafield definition for use in admin filtering.
/// </summary>
public enum MetafieldDefinitionAdminFilterStatus
{
    NOT_FILTERABLE,
    IN_PROGRESS,
    FILTERABLE,
    FAILED,
}