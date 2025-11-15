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

public class DeliveryProfileCreateQueryBuilder() : GraphQueryBuilder<DeliveryProfileCreatePayload>("query deliveryProfileCreate")
{
    public DeliveryProfileCreateQueryBuilder AddArgumentProfile(DeliveryProfileInput? profile)
    {
        AddArgument("profile", profile);
        return this;
    }
}