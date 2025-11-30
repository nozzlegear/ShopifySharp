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

public class ShippingLineConnectionQueryBuilder() : GraphQueryBuilder<ShippingLineConnection>("shippingLineConnection")
{
    public ShippingLineConnectionQueryBuilder AddFieldEdges(Func<ShippingLineEdgeQueryBuilder, ShippingLineEdgeQueryBuilder> build)
    {
        AddField<ShippingLineEdge, ShippingLineEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ShippingLineConnectionQueryBuilder AddFieldNodes(Func<ShippingLineQueryBuilder, ShippingLineQueryBuilder> build)
    {
        AddField<ShippingLine, ShippingLineQueryBuilder>("nodes", build);
        return this;
    }

    public ShippingLineConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}