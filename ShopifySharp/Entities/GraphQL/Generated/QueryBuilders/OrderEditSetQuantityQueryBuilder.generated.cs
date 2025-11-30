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

public class OrderEditSetQuantityQueryBuilder() : GraphQueryBuilder<OrderEditSetQuantityPayload>("orderEditSetQuantity"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public OrderEditSetQuantityQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public OrderEditSetQuantityQueryBuilder AddArgumentLineItemId(string? lineItemId)
    {
        AddArgument("lineItemId", lineItemId);
        return this;
    }

    public OrderEditSetQuantityQueryBuilder AddArgumentQuantity(int? quantity)
    {
        AddArgument("quantity", quantity);
        return this;
    }

    public OrderEditSetQuantityQueryBuilder AddArgumentRestock(bool? restock)
    {
        AddArgument("restock", restock);
        return this;
    }
}