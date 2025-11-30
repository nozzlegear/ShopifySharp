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

public class DeliveryProfileItemConnectionQueryBuilder() : GraphQueryBuilder<DeliveryProfileItemConnection>("deliveryProfileItemConnection")
{
    public DeliveryProfileItemConnectionQueryBuilder AddFieldEdges(Func<DeliveryProfileItemEdgeQueryBuilder, DeliveryProfileItemEdgeQueryBuilder> build)
    {
        AddField<DeliveryProfileItemEdge, DeliveryProfileItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DeliveryProfileItemConnectionQueryBuilder AddFieldNodes(Func<DeliveryProfileItemQueryBuilder, DeliveryProfileItemQueryBuilder> build)
    {
        AddField<DeliveryProfileItem, DeliveryProfileItemQueryBuilder>("nodes", build);
        return this;
    }

    public DeliveryProfileItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}