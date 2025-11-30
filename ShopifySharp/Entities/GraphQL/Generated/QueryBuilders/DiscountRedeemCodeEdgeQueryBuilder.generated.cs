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

public class DiscountRedeemCodeEdgeQueryBuilder() : GraphQueryBuilder<DiscountRedeemCodeEdge>("discountRedeemCodeEdge")
{
    public DiscountRedeemCodeEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DiscountRedeemCodeEdgeQueryBuilder AddFieldNode(Func<DiscountRedeemCodeQueryBuilder, DiscountRedeemCodeQueryBuilder> build)
    {
        AddField<DiscountRedeemCode, DiscountRedeemCodeQueryBuilder>("node", build);
        return this;
    }
}