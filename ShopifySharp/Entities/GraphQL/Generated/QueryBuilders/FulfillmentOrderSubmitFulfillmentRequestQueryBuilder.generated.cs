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

public class FulfillmentOrderSubmitFulfillmentRequestQueryBuilder() : GraphQueryBuilder<FulfillmentOrderSubmitFulfillmentRequestPayload>("fulfillmentOrderSubmitFulfillmentRequest"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public FulfillmentOrderSubmitFulfillmentRequestQueryBuilder AddArgumentFulfillmentOrderLineItems(ICollection<FulfillmentOrderLineItemInput>? fulfillmentOrderLineItems)
    {
        AddArgument("fulfillmentOrderLineItems", fulfillmentOrderLineItems);
        return this;
    }

    public FulfillmentOrderSubmitFulfillmentRequestQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public FulfillmentOrderSubmitFulfillmentRequestQueryBuilder AddArgumentMessage(string? message)
    {
        AddArgument("message", message);
        return this;
    }

    public FulfillmentOrderSubmitFulfillmentRequestQueryBuilder AddArgumentNotifyCustomer(bool? notifyCustomer)
    {
        AddArgument("notifyCustomer", notifyCustomer);
        return this;
    }
}