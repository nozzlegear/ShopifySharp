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
/// The relation for comparing variant titles.
/// </summary>
public enum CollectionSourceInclusionConditionVariantTitleRelation
{
    EQUALS,
    NOT_EQUALS,
    STARTS_WITH,
    ENDS_WITH,
    CONTAINS,
    DOES_NOT_CONTAIN,
}