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

public class DeliveryCustomizationConnectionQueryBuilder() : GraphQueryBuilder<DeliveryCustomizationConnection>("deliveryCustomizationConnection")
{
    public DeliveryCustomizationConnectionQueryBuilder AddFieldEdges(Func<DeliveryCustomizationEdgeQueryBuilder, DeliveryCustomizationEdgeQueryBuilder> build)
    {
        AddField<DeliveryCustomizationEdge, DeliveryCustomizationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DeliveryCustomizationConnectionQueryBuilder AddFieldNodes(Func<DeliveryCustomizationQueryBuilder, DeliveryCustomizationQueryBuilder> build)
    {
        AddField<DeliveryCustomization, DeliveryCustomizationQueryBuilder>("nodes", build);
        return this;
    }

    public DeliveryCustomizationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}