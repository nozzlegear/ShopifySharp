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

public class OrderCreateQueryBuilder() : GraphQueryBuilder<OrderCreatePayload>("orderCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public OrderCreateQueryBuilder AddArgumentOptions(OrderCreateOptionsInput? options)
    {
        AddArgument("options", options);
        return this;
    }

    public OrderCreateQueryBuilder AddArgumentOrder(OrderCreateOrderInput? order)
    {
        AddArgument("order", order);
        return this;
    }
}