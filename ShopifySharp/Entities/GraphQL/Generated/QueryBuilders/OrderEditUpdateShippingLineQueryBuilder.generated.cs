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

public class OrderEditUpdateShippingLineQueryBuilder() : GraphQueryBuilder<OrderEditUpdateShippingLinePayload>("orderEditUpdateShippingLine"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public OrderEditUpdateShippingLineQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public OrderEditUpdateShippingLineQueryBuilder AddArgumentShippingLine(OrderEditUpdateShippingLineInput? shippingLine)
    {
        AddArgument("shippingLine", shippingLine);
        return this;
    }

    public OrderEditUpdateShippingLineQueryBuilder AddArgumentShippingLineId(string? shippingLineId)
    {
        AddArgument("shippingLineId", shippingLineId);
        return this;
    }
}