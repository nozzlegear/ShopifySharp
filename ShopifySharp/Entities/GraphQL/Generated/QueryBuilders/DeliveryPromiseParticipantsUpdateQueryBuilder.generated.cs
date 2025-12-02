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

public class DeliveryPromiseParticipantsUpdateQueryBuilder() : GraphQueryBuilder<DeliveryPromiseParticipantsUpdatePayload>("deliveryPromiseParticipantsUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public DeliveryPromiseParticipantsUpdateQueryBuilder AddArgumentBrandedPromiseHandle(string? brandedPromiseHandle)
    {
        AddArgument("brandedPromiseHandle", brandedPromiseHandle);
        return this;
    }

    public DeliveryPromiseParticipantsUpdateQueryBuilder AddArgumentOwnersToAdd(ICollection<string>? ownersToAdd)
    {
        AddArgument("ownersToAdd", ownersToAdd);
        return this;
    }

    public DeliveryPromiseParticipantsUpdateQueryBuilder AddArgumentOwnersToRemove(ICollection<string>? ownersToRemove)
    {
        AddArgument("ownersToRemove", ownersToRemove);
        return this;
    }
}