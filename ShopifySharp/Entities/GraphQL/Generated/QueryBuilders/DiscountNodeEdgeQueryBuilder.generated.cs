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

public class DiscountNodeEdgeQueryBuilder() : GraphQueryBuilder<DiscountNodeEdge>("discountNodeEdge")
{
    public DiscountNodeEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DiscountNodeEdgeQueryBuilder AddFieldNode(Func<DiscountNodeQueryBuilder, DiscountNodeQueryBuilder> build)
    {
        AddField<DiscountNode, DiscountNodeQueryBuilder>("node", build);
        return this;
    }
}