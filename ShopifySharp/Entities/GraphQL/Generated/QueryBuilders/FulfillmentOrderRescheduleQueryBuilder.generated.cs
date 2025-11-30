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

public class FulfillmentOrderRescheduleQueryBuilder() : GraphQueryBuilder<FulfillmentOrderReschedulePayload>("fulfillmentOrderReschedule"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public FulfillmentOrderRescheduleQueryBuilder AddArgumentFulfillAt(DateTime? fulfillAt)
    {
        AddArgument("fulfillAt", fulfillAt);
        return this;
    }

    public FulfillmentOrderRescheduleQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}