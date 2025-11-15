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

public class DeliveryProfileConnectionQueryBuilder() : GraphQueryBuilder<DeliveryProfileConnection>("query deliveryProfileConnection")
{
    public DeliveryProfileConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public DeliveryProfileConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public DeliveryProfileConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}