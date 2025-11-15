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

public class ReverseDeliveryShippingUpdatePayloadQueryBuilder() : GraphQueryBuilder<ReverseDeliveryShippingUpdatePayload>("query reverseDeliveryShippingUpdatePayload")
{
    public ReverseDeliveryShippingUpdatePayloadQueryBuilder AddFieldReverseDelivery()
    {
        AddField("reverseDelivery");
        return this;
    }

    public ReverseDeliveryShippingUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}