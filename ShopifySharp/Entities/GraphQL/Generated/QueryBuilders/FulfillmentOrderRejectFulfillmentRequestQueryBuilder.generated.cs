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

public class FulfillmentOrderRejectFulfillmentRequestQueryBuilder() : GraphQueryBuilder<FulfillmentOrderRejectFulfillmentRequestPayload>("fulfillmentOrderRejectFulfillmentRequest"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public FulfillmentOrderRejectFulfillmentRequestQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public FulfillmentOrderRejectFulfillmentRequestQueryBuilder AddArgumentLineItems(ICollection<IncomingRequestLineItemInput>? lineItems)
    {
        AddArgument("lineItems", lineItems);
        return this;
    }

    public FulfillmentOrderRejectFulfillmentRequestQueryBuilder AddArgumentMessage(string? message)
    {
        AddArgument("message", message);
        return this;
    }

    public FulfillmentOrderRejectFulfillmentRequestQueryBuilder AddArgumentReason(FulfillmentOrderRejectionReason? reason)
    {
        AddArgument("reason", reason);
        return this;
    }
}