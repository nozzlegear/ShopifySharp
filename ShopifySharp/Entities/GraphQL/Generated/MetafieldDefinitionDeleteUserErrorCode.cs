#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `MetafieldDefinitionDeleteUserError`.
/// </summary>
public enum MetafieldDefinitionDeleteUserErrorCode
{
    PRESENT,
    NOT_FOUND,
    INTERNAL_ERROR,
    ID_TYPE_DELETION_ERROR,
    REFERENCE_TYPE_DELETION_ERROR,
    RESERVED_NAMESPACE_ORPHANED_METAFIELDS,
    METAFIELD_DEFINITION_IN_USE,
    APP_CONFIG_MANAGED,
    DISALLOWED_OWNER_TYPE,
}