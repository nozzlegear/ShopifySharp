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

public class OrderEditAddLineItemDiscountQueryBuilder() : GraphQueryBuilder<OrderEditAddLineItemDiscountPayload>("orderEditAddLineItemDiscount"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public OrderEditAddLineItemDiscountQueryBuilder AddArgumentDiscount(OrderEditAppliedDiscountInput? discount)
    {
        AddArgument("discount", discount);
        return this;
    }

    public OrderEditAddLineItemDiscountQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public OrderEditAddLineItemDiscountQueryBuilder AddArgumentLineItemId(string? lineItemId)
    {
        AddArgument("lineItemId", lineItemId);
        return this;
    }
}