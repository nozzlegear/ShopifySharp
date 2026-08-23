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
/// A condition that determines which products should be excluded from a collection.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CollectionSourceExclusionConditionCollection), typeDiscriminator: "CollectionSourceExclusionConditionCollection")]
[JsonDerivedType(typeof(CollectionSourceExclusionConditionProductCategory), typeDiscriminator: "CollectionSourceExclusionConditionProductCategory")]
[JsonDerivedType(typeof(CollectionSourceExclusionConditionProductTag), typeDiscriminator: "CollectionSourceExclusionConditionProductTag")]
[JsonDerivedType(typeof(CollectionSourceExclusionConditionProductType), typeDiscriminator: "CollectionSourceExclusionConditionProductType")]
[JsonDerivedType(typeof(CollectionSourceExclusionConditionProductVendor), typeDiscriminator: "CollectionSourceExclusionConditionProductVendor")]
[JsonDerivedType(typeof(CollectionSourceExclusionConditionUnknown), typeDiscriminator: "CollectionSourceExclusionConditionUnknown")]
public interface ICollectionSourceExclusionCondition : IGraphQLObject
{
    /// <summary>
    /// The unique identifier for this exclusion condition.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }
}