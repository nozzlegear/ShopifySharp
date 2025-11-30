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

public class FulfillmentTrackingInfoUpdateQueryBuilder() : GraphQueryBuilder<FulfillmentTrackingInfoUpdatePayload>("fulfillmentTrackingInfoUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public FulfillmentTrackingInfoUpdateQueryBuilder AddArgumentFulfillmentId(string? fulfillmentId)
    {
        AddArgument("fulfillmentId", fulfillmentId);
        return this;
    }

    public FulfillmentTrackingInfoUpdateQueryBuilder AddArgumentNotifyCustomer(bool? notifyCustomer)
    {
        AddArgument("notifyCustomer", notifyCustomer);
        return this;
    }

    public FulfillmentTrackingInfoUpdateQueryBuilder AddArgumentTrackingInfoInput(FulfillmentTrackingInput? trackingInfoInput)
    {
        AddArgument("trackingInfoInput", trackingInfoInput);
        return this;
    }
}