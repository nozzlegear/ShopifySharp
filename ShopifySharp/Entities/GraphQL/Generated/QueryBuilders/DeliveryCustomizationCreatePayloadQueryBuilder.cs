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

public class DeliveryCustomizationCreatePayloadQueryBuilder() : GraphQueryBuilder<DeliveryCustomizationCreatePayload>("query deliveryCustomizationCreatePayload")
{
    public DeliveryCustomizationCreatePayloadQueryBuilder AddFieldDeliveryCustomization()
    {
        AddField("deliveryCustomization");
        return this;
    }

    public DeliveryCustomizationCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}