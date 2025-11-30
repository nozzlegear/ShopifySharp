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

public class DeliveryCustomizationUpdatePayloadQueryBuilder() : GraphQueryBuilder<DeliveryCustomizationUpdatePayload>("query deliveryCustomizationUpdatePayload")
{
    public DeliveryCustomizationUpdatePayloadQueryBuilder AddFieldDeliveryCustomization()
    {
        AddField("deliveryCustomization");
        return this;
    }

    public DeliveryCustomizationUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}