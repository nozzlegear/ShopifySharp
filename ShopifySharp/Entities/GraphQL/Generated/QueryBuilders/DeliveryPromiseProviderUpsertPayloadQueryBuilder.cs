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

public class DeliveryPromiseProviderUpsertPayloadQueryBuilder() : GraphQueryBuilder<DeliveryPromiseProviderUpsertPayload>("query deliveryPromiseProviderUpsertPayload")
{
    public DeliveryPromiseProviderUpsertPayloadQueryBuilder AddFieldDeliveryPromiseProvider()
    {
        AddField("deliveryPromiseProvider");
        return this;
    }

    public DeliveryPromiseProviderUpsertPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}