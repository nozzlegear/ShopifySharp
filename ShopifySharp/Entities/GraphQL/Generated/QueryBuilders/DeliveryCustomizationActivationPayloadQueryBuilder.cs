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

public class DeliveryCustomizationActivationPayloadQueryBuilder() : GraphQueryBuilder<DeliveryCustomizationActivationPayload>("query deliveryCustomizationActivationPayload")
{
    public DeliveryCustomizationActivationPayloadQueryBuilder AddFieldIds()
    {
        AddField("ids");
        return this;
    }

    public DeliveryCustomizationActivationPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}