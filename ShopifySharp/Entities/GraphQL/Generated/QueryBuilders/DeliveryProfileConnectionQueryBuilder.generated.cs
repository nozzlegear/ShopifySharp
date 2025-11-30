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

public class DeliveryProfileConnectionQueryBuilder() : GraphQueryBuilder<DeliveryProfileConnection>("deliveryProfileConnection")
{
    public DeliveryProfileConnectionQueryBuilder AddFieldEdges(Func<DeliveryProfileEdgeQueryBuilder, DeliveryProfileEdgeQueryBuilder> build)
    {
        AddField<DeliveryProfileEdge, DeliveryProfileEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DeliveryProfileConnectionQueryBuilder AddFieldNodes(Func<DeliveryProfileQueryBuilder, DeliveryProfileQueryBuilder> build)
    {
        AddField<DeliveryProfile, DeliveryProfileQueryBuilder>("nodes", build);
        return this;
    }

    public DeliveryProfileConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}