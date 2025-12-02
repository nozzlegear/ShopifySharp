#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CollectionRuleQueryBuilder() : GraphQueryBuilder<CollectionRule>("collectionRule")
{
    public CollectionRuleQueryBuilder AddFieldColumn()
    {
        AddField("column");
        return this;
    }

    public CollectionRuleQueryBuilder AddFieldCondition()
    {
        AddField("condition");
        return this;
    }

    public CollectionRuleQueryBuilder AddUnionCaseConditionObject(Func<CollectionRuleCategoryConditionQueryBuilder, CollectionRuleCategoryConditionQueryBuilder> build)
    {
        AddUnion<CollectionRuleCategoryCondition, CollectionRuleCategoryConditionQueryBuilder>("conditionObject", build);
        return this;
    }

    public CollectionRuleQueryBuilder AddUnionCaseConditionObject(Func<CollectionRuleMetafieldConditionQueryBuilder, CollectionRuleMetafieldConditionQueryBuilder> build)
    {
        AddUnion<CollectionRuleMetafieldCondition, CollectionRuleMetafieldConditionQueryBuilder>("conditionObject", build);
        return this;
    }

    public CollectionRuleQueryBuilder AddUnionCaseConditionObject(Func<CollectionRuleProductCategoryConditionQueryBuilder, CollectionRuleProductCategoryConditionQueryBuilder> build)
    {
        AddUnion<CollectionRuleProductCategoryCondition, CollectionRuleProductCategoryConditionQueryBuilder>("conditionObject", build);
        return this;
    }

    public CollectionRuleQueryBuilder AddUnionCaseConditionObject(Func<CollectionRuleTextConditionQueryBuilder, CollectionRuleTextConditionQueryBuilder> build)
    {
        AddUnion<CollectionRuleTextCondition, CollectionRuleTextConditionQueryBuilder>("conditionObject", build);
        return this;
    }

    public CollectionRuleQueryBuilder AddFieldRelation()
    {
        AddField("relation");
        return this;
    }
}