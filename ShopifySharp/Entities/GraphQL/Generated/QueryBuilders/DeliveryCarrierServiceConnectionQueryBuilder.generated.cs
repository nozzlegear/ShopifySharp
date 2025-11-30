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

public class DeliveryCarrierServiceConnectionQueryBuilder() : GraphQueryBuilder<DeliveryCarrierServiceConnection>("deliveryCarrierServiceConnection")
{
    public DeliveryCarrierServiceConnectionQueryBuilder AddFieldEdges(Func<DeliveryCarrierServiceEdgeQueryBuilder, DeliveryCarrierServiceEdgeQueryBuilder> build)
    {
        AddField<DeliveryCarrierServiceEdge, DeliveryCarrierServiceEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DeliveryCarrierServiceConnectionQueryBuilder AddFieldNodes(Func<DeliveryCarrierServiceQueryBuilder, DeliveryCarrierServiceQueryBuilder> build)
    {
        AddField<DeliveryCarrierService, DeliveryCarrierServiceQueryBuilder>("nodes", build);
        return this;
    }

    public DeliveryCarrierServiceConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}