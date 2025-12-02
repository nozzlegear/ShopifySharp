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

[Obsolete("Use `fulfillmentTrackingInfoUpdate` instead.")]
public class FulfillmentTrackingInfoUpdateV2QueryBuilder() : GraphQueryBuilder<FulfillmentTrackingInfoUpdateV2Payload>("fulfillmentTrackingInfoUpdateV2"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public FulfillmentTrackingInfoUpdateV2QueryBuilder AddArgumentFulfillmentId(string? fulfillmentId)
    {
        AddArgument("fulfillmentId", fulfillmentId);
        return this;
    }

    public FulfillmentTrackingInfoUpdateV2QueryBuilder AddArgumentNotifyCustomer(bool? notifyCustomer)
    {
        AddArgument("notifyCustomer", notifyCustomer);
        return this;
    }

    public FulfillmentTrackingInfoUpdateV2QueryBuilder AddArgumentTrackingInfoInput(FulfillmentTrackingInput? trackingInfoInput)
    {
        AddArgument("trackingInfoInput", trackingInfoInput);
        return this;
    }
}