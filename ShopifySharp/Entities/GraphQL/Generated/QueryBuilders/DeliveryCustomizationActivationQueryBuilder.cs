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

public class DeliveryCustomizationActivationQueryBuilder() : GraphQueryBuilder<DeliveryCustomizationActivationPayload>("query deliveryCustomizationActivation")
{
    public DeliveryCustomizationActivationQueryBuilder AddArgumentEnabled(bool? enabled)
    {
        AddArgument("enabled", enabled);
        return this;
    }

    public DeliveryCustomizationActivationQueryBuilder AddArgumentIds(ICollection<string>? ids)
    {
        AddArgument("ids", ids);
        return this;
    }
}