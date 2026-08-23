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
/// The relation for comparing variant weights.
/// </summary>
public enum CollectionSourceInclusionConditionVariantWeightRelation
{
    EQUALS,
    NOT_EQUALS,
    GREATER_THAN,
    LESS_THAN,
}