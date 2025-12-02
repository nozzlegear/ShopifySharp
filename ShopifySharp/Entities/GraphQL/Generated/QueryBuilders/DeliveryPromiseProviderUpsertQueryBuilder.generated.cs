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

public class DeliveryPromiseProviderUpsertQueryBuilder() : GraphQueryBuilder<DeliveryPromiseProviderUpsertPayload>("deliveryPromiseProviderUpsert"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public DeliveryPromiseProviderUpsertQueryBuilder AddArgumentActive(bool? active)
    {
        AddArgument("active", active);
        return this;
    }

    public DeliveryPromiseProviderUpsertQueryBuilder AddArgumentFulfillmentDelay(int? fulfillmentDelay)
    {
        AddArgument("fulfillmentDelay", fulfillmentDelay);
        return this;
    }

    public DeliveryPromiseProviderUpsertQueryBuilder AddArgumentLocationId(string? locationId)
    {
        AddArgument("locationId", locationId);
        return this;
    }

    public DeliveryPromiseProviderUpsertQueryBuilder AddArgumentTimeZone(string? timeZone)
    {
        AddArgument("timeZone", timeZone);
        return this;
    }
}