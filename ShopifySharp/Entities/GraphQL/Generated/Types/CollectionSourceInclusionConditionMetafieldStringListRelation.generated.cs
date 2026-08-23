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
/// The relationship between the metafield value and the condition values.
/// </summary>
public enum CollectionSourceInclusionConditionMetafieldStringListRelation
{
    INCLUDES,
}