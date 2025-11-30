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

public class DeliveryCustomizationCreateQueryBuilder() : GraphQueryBuilder<DeliveryCustomizationCreatePayload>("query deliveryCustomizationCreate")
{
    public DeliveryCustomizationCreateQueryBuilder AddArgumentDeliveryCustomization(DeliveryCustomizationInput? deliveryCustomization)
    {
        AddArgument("deliveryCustomization", deliveryCustomization);
        return this;
    }
}