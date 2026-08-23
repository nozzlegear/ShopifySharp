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
/// The relationship between the product title and the condition values.
/// </summary>
public enum CollectionSourceInclusionConditionProductTitleRelation
{
    EQUALS,
    NOT_EQUALS,
    CONTAINS,
    DOES_NOT_CONTAIN,
    STARTS_WITH,
    ENDS_WITH,
}