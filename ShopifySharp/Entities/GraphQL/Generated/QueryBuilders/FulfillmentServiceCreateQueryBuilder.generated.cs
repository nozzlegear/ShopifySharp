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

public class FulfillmentServiceCreateQueryBuilder() : GraphQueryBuilder<FulfillmentServiceCreatePayload>("fulfillmentServiceCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public FulfillmentServiceCreateQueryBuilder AddArgumentCallbackUrl(string? callbackUrl)
    {
        AddArgument("callbackUrl", callbackUrl);
        return this;
    }

    public FulfillmentServiceCreateQueryBuilder AddArgumentInventoryManagement(bool? inventoryManagement)
    {
        AddArgument("inventoryManagement", inventoryManagement);
        return this;
    }

    public FulfillmentServiceCreateQueryBuilder AddArgumentName(string? name)
    {
        AddArgument("name", name);
        return this;
    }

    public FulfillmentServiceCreateQueryBuilder AddArgumentRequiresShippingMethod(bool? requiresShippingMethod)
    {
        AddArgument("requiresShippingMethod", requiresShippingMethod);
        return this;
    }

    public FulfillmentServiceCreateQueryBuilder AddArgumentTrackingSupport(bool? trackingSupport)
    {
        AddArgument("trackingSupport", trackingSupport);
        return this;
    }
}