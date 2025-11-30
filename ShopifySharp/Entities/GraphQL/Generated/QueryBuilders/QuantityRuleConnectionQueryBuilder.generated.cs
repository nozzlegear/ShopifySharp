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

public class QuantityRuleConnectionQueryBuilder() : GraphQueryBuilder<QuantityRuleConnection>("quantityRuleConnection")
{
    public QuantityRuleConnectionQueryBuilder AddFieldEdges(Func<QuantityRuleEdgeQueryBuilder, QuantityRuleEdgeQueryBuilder> build)
    {
        AddField<QuantityRuleEdge, QuantityRuleEdgeQueryBuilder>("edges", build);
        return this;
    }

    public QuantityRuleConnectionQueryBuilder AddFieldNodes(Func<QuantityRuleQueryBuilder, QuantityRuleQueryBuilder> build)
    {
        AddField<QuantityRule, QuantityRuleQueryBuilder>("nodes", build);
        return this;
    }

    public QuantityRuleConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}