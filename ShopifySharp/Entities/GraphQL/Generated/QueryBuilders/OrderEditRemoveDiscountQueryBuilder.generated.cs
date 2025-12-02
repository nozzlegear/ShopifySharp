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

public class OrderEditRemoveDiscountQueryBuilder() : GraphQueryBuilder<OrderEditRemoveDiscountPayload>("orderEditRemoveDiscount"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public OrderEditRemoveDiscountQueryBuilder AddArgumentDiscountApplicationId(string? discountApplicationId)
    {
        AddArgument("discountApplicationId", discountApplicationId);
        return this;
    }

    public OrderEditRemoveDiscountQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}