#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Specifies object for the condition of the rule.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CollectionRuleCategoryCondition), typeDiscriminator: "CollectionRuleCategoryCondition")]
[JsonDerivedType(typeof(CollectionRuleMetafieldCondition), typeDiscriminator: "CollectionRuleMetafieldCondition")]
[JsonDerivedType(typeof(CollectionRuleProductCategoryCondition), typeDiscriminator: "CollectionRuleProductCategoryCondition")]
[JsonDerivedType(typeof(CollectionRuleTextCondition), typeDiscriminator: "CollectionRuleTextCondition")]
public record CollectionRuleConditionObject : GraphQLObject<CollectionRuleConditionObject>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public CollectionRuleCategoryCondition? AsCollectionRuleCategoryCondition() => this is CollectionRuleConditionObjectCollectionRuleCategoryCondition wrapper ? wrapper.Value : null;
	public CollectionRuleMetafieldCondition? AsCollectionRuleMetafieldCondition() => this is CollectionRuleConditionObjectCollectionRuleMetafieldCondition wrapper ? wrapper.Value : null;
	public CollectionRuleProductCategoryCondition? AsCollectionRuleProductCategoryCondition() => this is CollectionRuleConditionObjectCollectionRuleProductCategoryCondition wrapper ? wrapper.Value : null;
	public CollectionRuleTextCondition? AsCollectionRuleTextCondition() => this is CollectionRuleConditionObjectCollectionRuleTextCondition wrapper ? wrapper.Value : null;
#endif
}