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

public class OrderCancelQueryBuilder() : GraphQueryBuilder<OrderCancelPayload>("orderCancel"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public OrderCancelQueryBuilder AddArgumentNotifyCustomer(bool? notifyCustomer)
    {
        AddArgument("notifyCustomer", notifyCustomer);
        return this;
    }

    public OrderCancelQueryBuilder AddArgumentOrderId(string? orderId)
    {
        AddArgument("orderId", orderId);
        return this;
    }

    public OrderCancelQueryBuilder AddArgumentReason(OrderCancelReason? reason)
    {
        AddArgument("reason", reason);
        return this;
    }

    public OrderCancelQueryBuilder AddArgumentRefundMethod(OrderCancelRefundMethodInput? refundMethod)
    {
        AddArgument("refundMethod", refundMethod);
        return this;
    }

    public OrderCancelQueryBuilder AddArgumentRestock(bool? restock)
    {
        AddArgument("restock", restock);
        return this;
    }

    public OrderCancelQueryBuilder AddArgumentStaffNote(string? staffNote)
    {
        AddArgument("staffNote", staffNote);
        return this;
    }
}