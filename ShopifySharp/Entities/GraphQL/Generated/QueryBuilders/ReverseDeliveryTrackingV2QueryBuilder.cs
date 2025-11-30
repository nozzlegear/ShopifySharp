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

public class ReverseDeliveryTrackingV2QueryBuilder() : GraphQueryBuilder<ReverseDeliveryTrackingV2>("query reverseDeliveryTrackingV2")
{
    public ReverseDeliveryTrackingV2QueryBuilder AddFieldCarrierName()
    {
        AddField("carrierName");
        return this;
    }

    public ReverseDeliveryTrackingV2QueryBuilder AddFieldNumber()
    {
        AddField("number");
        return this;
    }

    public ReverseDeliveryTrackingV2QueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}