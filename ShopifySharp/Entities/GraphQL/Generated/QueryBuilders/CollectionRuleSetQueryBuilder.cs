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

public class CollectionRuleSetQueryBuilder() : GraphQueryBuilder<CollectionRuleSet>("query collectionRuleSet")
{
    public CollectionRuleSetQueryBuilder AddFieldAppliedDisjunctively()
    {
        AddField("appliedDisjunctively");
        return this;
    }

    public CollectionRuleSetQueryBuilder AddFieldRules()
    {
        AddField("rules");
        return this;
    }
}