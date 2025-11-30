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

public class ReverseDeliveryConnectionQueryBuilder() : GraphQueryBuilder<ReverseDeliveryConnection>("reverseDeliveryConnection")
{
    public ReverseDeliveryConnectionQueryBuilder AddFieldEdges(Func<ReverseDeliveryEdgeQueryBuilder, ReverseDeliveryEdgeQueryBuilder> build)
    {
        AddField<ReverseDeliveryEdge, ReverseDeliveryEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ReverseDeliveryConnectionQueryBuilder AddFieldNodes(Func<ReverseDeliveryQueryBuilder, ReverseDeliveryQueryBuilder> build)
    {
        AddField<ReverseDelivery, ReverseDeliveryQueryBuilder>("nodes", build);
        return this;
    }

    public ReverseDeliveryConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}