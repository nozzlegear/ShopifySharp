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

public class OrderCreateMandatePaymentQueryBuilder() : GraphQueryBuilder<OrderCreateMandatePaymentPayload>("orderCreateMandatePayment"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public OrderCreateMandatePaymentQueryBuilder AddArgumentAmount(MoneyInput? amount)
    {
        AddArgument("amount", amount);
        return this;
    }

    public OrderCreateMandatePaymentQueryBuilder AddArgumentAutoCapture(bool? autoCapture)
    {
        AddArgument("autoCapture", autoCapture);
        return this;
    }

    public OrderCreateMandatePaymentQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public OrderCreateMandatePaymentQueryBuilder AddArgumentIdempotencyKey(string? idempotencyKey)
    {
        AddArgument("idempotencyKey", idempotencyKey);
        return this;
    }

    public OrderCreateMandatePaymentQueryBuilder AddArgumentMandateId(string? mandateId)
    {
        AddArgument("mandateId", mandateId);
        return this;
    }

    public OrderCreateMandatePaymentQueryBuilder AddArgumentPaymentScheduleId(string? paymentScheduleId)
    {
        AddArgument("paymentScheduleId", paymentScheduleId);
        return this;
    }
}