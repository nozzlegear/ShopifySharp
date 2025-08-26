#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Specifies object with additional rule attributes.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CollectionRuleConditionsRuleObjectCollectionRuleMetafieldCondition), typeDiscriminator: "CollectionRuleMetafieldCondition")]
public record CollectionRuleConditionsRuleObject : GraphQLObject<CollectionRuleConditionsRuleObject>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public CollectionRuleMetafieldCondition? AsCollectionRuleMetafieldCondition() => this is CollectionRuleConditionsRuleObjectCollectionRuleMetafieldCondition wrapper ? wrapper.Value : null;
#endif
}