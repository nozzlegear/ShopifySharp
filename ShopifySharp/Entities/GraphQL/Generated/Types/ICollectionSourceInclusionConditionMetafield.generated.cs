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
/// A condition that determines which products should be included in a collection.
/// This is an interface implemented by a concrete type per condition kind (for example,
/// `CollectionSourceInclusionConditionProductTag` or `CollectionSourceInclusionConditionVariantTitle`).
/// Fields such as `relation` are defined on each concrete type and return a type-specific enum (for example,
/// `CollectionSourceInclusionConditionProductTagRelation` versus
/// `CollectionSourceInclusionConditionVariantTitleRelation`). Conditions are mutually exclusive concrete
/// types, but may contain overlapping field names such as `relation`. If your GraphQL tooling flags these
/// as ambiguous, give each field a distinct alias (for example, `tagRelation: relation` and
/// `variantTitleRelation: relation`) or use inline fragments.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CollectionSourceInclusionConditionMetafieldBoolean), typeDiscriminator: "CollectionSourceInclusionConditionMetafieldBoolean")]
[JsonDerivedType(typeof(CollectionSourceInclusionConditionMetafieldDecimal), typeDiscriminator: "CollectionSourceInclusionConditionMetafieldDecimal")]
[JsonDerivedType(typeof(CollectionSourceInclusionConditionMetafieldInteger), typeDiscriminator: "CollectionSourceInclusionConditionMetafieldInteger")]
[JsonDerivedType(typeof(CollectionSourceInclusionConditionMetafieldMetaobject), typeDiscriminator: "CollectionSourceInclusionConditionMetafieldMetaobject")]
[JsonDerivedType(typeof(CollectionSourceInclusionConditionMetafieldMetaobjectList), typeDiscriminator: "CollectionSourceInclusionConditionMetafieldMetaobjectList")]
[JsonDerivedType(typeof(CollectionSourceInclusionConditionMetafieldString), typeDiscriminator: "CollectionSourceInclusionConditionMetafieldString")]
[JsonDerivedType(typeof(CollectionSourceInclusionConditionMetafieldStringList), typeDiscriminator: "CollectionSourceInclusionConditionMetafieldStringList")]
public interface ICollectionSourceInclusionConditionMetafield : IGraphQLObject
{
    /// <summary>
    /// The metafield definition to use for the condition.
    /// </summary>
    [JsonPropertyName("definition")]
    public MetafieldDefinition? definition { get; set; }

    /// <summary>
    /// The unique identifier for this condition.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }
}