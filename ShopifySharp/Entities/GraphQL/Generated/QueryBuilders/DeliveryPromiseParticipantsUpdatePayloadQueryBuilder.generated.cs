#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class DeliveryPromiseParticipantsUpdatePayloadQueryBuilder() : GraphQueryBuilder<DeliveryPromiseParticipantsUpdatePayload>("deliveryPromiseParticipantsUpdatePayload")
{
    public DeliveryPromiseParticipantsUpdatePayloadQueryBuilder AddFieldPromiseParticipants(Func<DeliveryPromiseParticipantQueryBuilder, DeliveryPromiseParticipantQueryBuilder> build)
    {
        AddField<DeliveryPromiseParticipant, DeliveryPromiseParticipantQueryBuilder>("promiseParticipants", build);
        return this;
    }

    public DeliveryPromiseParticipantsUpdatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}