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
/// The relationship between the metaobject value and the condition values.
/// </summary>
public enum CollectionSourceInclusionConditionMetafieldMetaobjectListRelation
{
    INCLUDES,
}