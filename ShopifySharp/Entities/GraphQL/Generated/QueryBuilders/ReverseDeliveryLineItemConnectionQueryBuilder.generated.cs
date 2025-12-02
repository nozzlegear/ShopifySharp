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

public class ReverseDeliveryLineItemConnectionQueryBuilder() : GraphQueryBuilder<ReverseDeliveryLineItemConnection>("reverseDeliveryLineItemConnection")
{
    public ReverseDeliveryLineItemConnectionQueryBuilder AddFieldEdges(Func<ReverseDeliveryLineItemEdgeQueryBuilder, ReverseDeliveryLineItemEdgeQueryBuilder> build)
    {
        AddField<ReverseDeliveryLineItemEdge, ReverseDeliveryLineItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ReverseDeliveryLineItemConnectionQueryBuilder AddFieldNodes(Func<ReverseDeliveryLineItemQueryBuilder, ReverseDeliveryLineItemQueryBuilder> build)
    {
        AddField<ReverseDeliveryLineItem, ReverseDeliveryLineItemQueryBuilder>("nodes", build);
        return this;
    }

    public ReverseDeliveryLineItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}