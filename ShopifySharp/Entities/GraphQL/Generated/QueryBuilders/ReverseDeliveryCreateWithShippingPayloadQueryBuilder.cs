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

public class ReverseDeliveryCreateWithShippingPayloadQueryBuilder() : GraphQueryBuilder<ReverseDeliveryCreateWithShippingPayload>("query reverseDeliveryCreateWithShippingPayload")
{
    public ReverseDeliveryCreateWithShippingPayloadQueryBuilder AddFieldReverseDelivery()
    {
        AddField("reverseDelivery");
        return this;
    }

    public ReverseDeliveryCreateWithShippingPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}