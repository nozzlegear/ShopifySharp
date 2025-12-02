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

public class DiscountCodeNodeEdgeQueryBuilder() : GraphQueryBuilder<DiscountCodeNodeEdge>("discountCodeNodeEdge")
{
    public DiscountCodeNodeEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DiscountCodeNodeEdgeQueryBuilder AddFieldNode(Func<DiscountCodeNodeQueryBuilder, DiscountCodeNodeQueryBuilder> build)
    {
        AddField<DiscountCodeNode, DiscountCodeNodeQueryBuilder>("node", build);
        return this;
    }
}