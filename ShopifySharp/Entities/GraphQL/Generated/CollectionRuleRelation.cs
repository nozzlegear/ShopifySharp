#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Specifies the relationship between the `column` and the `condition`.
/// </summary>
public enum CollectionRuleRelation
{
    CONTAINS,
    ENDS_WITH,
    EQUALS,
    GREATER_THAN,
    IS_NOT_SET,
    IS_SET,
    LESS_THAN,
    NOT_CONTAINS,
    NOT_EQUALS,
    STARTS_WITH,
}