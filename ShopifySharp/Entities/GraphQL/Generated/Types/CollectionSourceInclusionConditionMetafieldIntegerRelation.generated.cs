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
/// The relation for comparing integer metafield values.
/// </summary>
public enum CollectionSourceInclusionConditionMetafieldIntegerRelation
{
    EQUALS,
    GREATER_THAN,
    LESS_THAN,
}