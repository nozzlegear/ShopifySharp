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

public class PriceRuleDiscountCodeConnectionQueryBuilder() : GraphQueryBuilder<PriceRuleDiscountCodeConnection>("priceRuleDiscountCodeConnection")
{
    public PriceRuleDiscountCodeConnectionQueryBuilder AddFieldEdges(Func<PriceRuleDiscountCodeEdgeQueryBuilder, PriceRuleDiscountCodeEdgeQueryBuilder> build)
    {
        AddField<PriceRuleDiscountCodeEdge, PriceRuleDiscountCodeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public PriceRuleDiscountCodeConnectionQueryBuilder AddFieldNodes(Func<PriceRuleDiscountCodeQueryBuilder, PriceRuleDiscountCodeQueryBuilder> build)
    {
        AddField<PriceRuleDiscountCode, PriceRuleDiscountCodeQueryBuilder>("nodes", build);
        return this;
    }

    public PriceRuleDiscountCodeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}