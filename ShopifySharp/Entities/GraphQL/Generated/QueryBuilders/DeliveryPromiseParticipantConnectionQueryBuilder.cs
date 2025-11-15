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

public class DeliveryPromiseParticipantConnectionQueryBuilder() : GraphQueryBuilder<DeliveryPromiseParticipantConnection>("query deliveryPromiseParticipantConnection")
{
    public DeliveryPromiseParticipantConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public DeliveryPromiseParticipantConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public DeliveryPromiseParticipantConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}