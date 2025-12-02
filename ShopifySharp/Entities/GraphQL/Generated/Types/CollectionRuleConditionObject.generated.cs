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
/// Specifies object for the condition of the rule.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<CollectionRuleConditionObject>))]
public record CollectionRuleConditionObject : GraphQLObject<CollectionRuleConditionObject>, IGraphQLUnionType
{
    public CollectionRuleCategoryCondition? AsCollectionRuleCategoryCondition() => this is CollectionRuleConditionObjectCollectionRuleCategoryCondition wrapper ? wrapper.Value : null;
    public CollectionRuleMetafieldCondition? AsCollectionRuleMetafieldCondition() => this is CollectionRuleConditionObjectCollectionRuleMetafieldCondition wrapper ? wrapper.Value : null;
    public CollectionRuleProductCategoryCondition? AsCollectionRuleProductCategoryCondition() => this is CollectionRuleConditionObjectCollectionRuleProductCategoryCondition wrapper ? wrapper.Value : null;
    public CollectionRuleTextCondition? AsCollectionRuleTextCondition() => this is CollectionRuleConditionObjectCollectionRuleTextCondition wrapper ? wrapper.Value : null;
}