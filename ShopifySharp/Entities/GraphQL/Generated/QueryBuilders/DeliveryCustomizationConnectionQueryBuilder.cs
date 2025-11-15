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

public class DeliveryCustomizationConnectionQueryBuilder() : GraphQueryBuilder<DeliveryCustomizationConnection>("query deliveryCustomizationConnection")
{
    public DeliveryCustomizationConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public DeliveryCustomizationConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public DeliveryCustomizationConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}