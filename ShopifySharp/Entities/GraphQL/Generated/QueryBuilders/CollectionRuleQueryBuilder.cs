#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CollectionRuleQueryBuilder() : GraphQueryBuilder<CollectionRule>("query collectionRule")
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

    public CollectionRuleQueryBuilder AddFieldConditionObject()
    {
        AddField("conditionObject");
        return this;
    }

    public CollectionRuleQueryBuilder AddFieldRelation()
    {
        AddField("relation");
        return this;
    }
}