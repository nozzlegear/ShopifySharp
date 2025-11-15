#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class DeliveryLocationGroupZoneConnectionQueryBuilder() : GraphQueryBuilder<DeliveryLocationGroupZoneConnection>("query deliveryLocationGroupZoneConnection")
{
    public DeliveryLocationGroupZoneConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public DeliveryLocationGroupZoneConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public DeliveryLocationGroupZoneConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}