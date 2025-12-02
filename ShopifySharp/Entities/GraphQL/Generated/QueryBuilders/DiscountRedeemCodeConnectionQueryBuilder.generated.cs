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

public class DiscountRedeemCodeConnectionQueryBuilder() : GraphQueryBuilder<DiscountRedeemCodeConnection>("discountRedeemCodeConnection")
{
    public DiscountRedeemCodeConnectionQueryBuilder AddFieldEdges(Func<DiscountRedeemCodeEdgeQueryBuilder, DiscountRedeemCodeEdgeQueryBuilder> build)
    {
        AddField<DiscountRedeemCodeEdge, DiscountRedeemCodeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DiscountRedeemCodeConnectionQueryBuilder AddFieldNodes(Func<DiscountRedeemCodeQueryBuilder, DiscountRedeemCodeQueryBuilder> build)
    {
        AddField<DiscountRedeemCode, DiscountRedeemCodeQueryBuilder>("nodes", build);
        return this;
    }

    public DiscountRedeemCodeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}