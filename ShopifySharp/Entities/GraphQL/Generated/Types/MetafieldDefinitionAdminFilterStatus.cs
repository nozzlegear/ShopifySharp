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
/// Possible filter statuses associated with a metafield definition for use in admin filtering.
/// </summary>
public enum MetafieldDefinitionAdminFilterStatus
{
    NOT_FILTERABLE,
    IN_PROGRESS,
    FILTERABLE,
    FAILED,
}