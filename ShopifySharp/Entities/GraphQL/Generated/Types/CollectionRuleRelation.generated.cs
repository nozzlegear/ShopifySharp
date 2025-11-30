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