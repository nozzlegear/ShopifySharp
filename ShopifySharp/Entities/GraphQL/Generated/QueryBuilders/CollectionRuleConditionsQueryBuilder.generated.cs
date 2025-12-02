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

public class CollectionRuleConditionsQueryBuilder() : GraphQueryBuilder<CollectionRuleConditions>("collectionRuleConditions")
{
    public CollectionRuleConditionsQueryBuilder AddFieldAllowedRelations()
    {
        AddField("allowedRelations");
        return this;
    }

    public CollectionRuleConditionsQueryBuilder AddFieldDefaultRelation()
    {
        AddField("defaultRelation");
        return this;
    }

    public CollectionRuleConditionsQueryBuilder AddUnionCaseRuleObject(Func<CollectionRuleMetafieldConditionQueryBuilder, CollectionRuleMetafieldConditionQueryBuilder> build)
    {
        AddUnion<CollectionRuleMetafieldCondition, CollectionRuleMetafieldConditionQueryBuilder>("ruleObject", build);
        return this;
    }

    public CollectionRuleConditionsQueryBuilder AddFieldRuleType()
    {
        AddField("ruleType");
        return this;
    }
}