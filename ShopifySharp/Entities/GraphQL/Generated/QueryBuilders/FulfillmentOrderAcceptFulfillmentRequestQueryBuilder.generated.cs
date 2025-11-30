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

public class FulfillmentOrderAcceptFulfillmentRequestQueryBuilder() : GraphQueryBuilder<FulfillmentOrderAcceptFulfillmentRequestPayload>("fulfillmentOrderAcceptFulfillmentRequest"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public FulfillmentOrderAcceptFulfillmentRequestQueryBuilder AddArgumentEstimatedShippedAt(DateTime? estimatedShippedAt)
    {
        AddArgument("estimatedShippedAt", estimatedShippedAt);
        return this;
    }

    public FulfillmentOrderAcceptFulfillmentRequestQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public FulfillmentOrderAcceptFulfillmentRequestQueryBuilder AddArgumentMessage(string? message)
    {
        AddArgument("message", message);
        return this;
    }
}