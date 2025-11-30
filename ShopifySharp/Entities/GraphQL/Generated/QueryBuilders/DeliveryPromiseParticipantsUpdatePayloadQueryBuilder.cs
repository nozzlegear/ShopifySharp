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

public class DeliveryPromiseParticipantsUpdatePayloadQueryBuilder() : GraphQueryBuilder<DeliveryPromiseParticipantsUpdatePayload>("query deliveryPromiseParticipantsUpdatePayload")
{
    public DeliveryPromiseParticipantsUpdatePayloadQueryBuilder AddFieldPromiseParticipants()
    {
        AddField("promiseParticipants");
        return this;
    }

    public DeliveryPromiseParticipantsUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}