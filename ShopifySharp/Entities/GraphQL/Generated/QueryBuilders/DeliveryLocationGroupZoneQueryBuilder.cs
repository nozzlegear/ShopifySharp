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

public class DeliveryLocationGroupZoneQueryBuilder() : GraphQueryBuilder<DeliveryLocationGroupZone>("query deliveryLocationGroupZone")
{
    public DeliveryLocationGroupZoneQueryBuilder AddFieldMethodDefinitionCounts()
    {
        AddField("methodDefinitionCounts");
        return this;
    }

    public DeliveryLocationGroupZoneQueryBuilder AddFieldMethodDefinitions()
    {
        AddField("methodDefinitions");
        return this;
    }

    public DeliveryLocationGroupZoneQueryBuilder AddFieldZone()
    {
        AddField("zone");
        return this;
    }
}