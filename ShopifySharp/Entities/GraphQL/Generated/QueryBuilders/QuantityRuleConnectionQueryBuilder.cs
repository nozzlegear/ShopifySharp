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

public class QuantityRuleConnectionQueryBuilder() : GraphQueryBuilder<QuantityRuleConnection>("query quantityRuleConnection")
{
    public QuantityRuleConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public QuantityRuleConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public QuantityRuleConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}