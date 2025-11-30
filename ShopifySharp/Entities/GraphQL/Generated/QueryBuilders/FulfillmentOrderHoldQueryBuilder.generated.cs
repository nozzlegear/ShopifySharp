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

public class FulfillmentOrderHoldQueryBuilder() : GraphQueryBuilder<FulfillmentOrderHoldPayload>("fulfillmentOrderHold"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public FulfillmentOrderHoldQueryBuilder AddArgumentFulfillmentHold(FulfillmentOrderHoldInput? fulfillmentHold)
    {
        AddArgument("fulfillmentHold", fulfillmentHold);
        return this;
    }

    public FulfillmentOrderHoldQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}