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

public class DeliveryProfileUpdatePayloadQueryBuilder() : GraphQueryBuilder<DeliveryProfileUpdatePayload>("query deliveryProfileUpdatePayload")
{
    public DeliveryProfileUpdatePayloadQueryBuilder AddFieldProfile()
    {
        AddField("profile");
        return this;
    }

    public DeliveryProfileUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}