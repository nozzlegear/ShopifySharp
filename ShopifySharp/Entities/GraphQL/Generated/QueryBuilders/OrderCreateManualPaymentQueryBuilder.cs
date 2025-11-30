#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class OrderCreateManualPaymentQueryBuilder() : GraphQueryBuilder<OrderCreateManualPaymentPayload>("query orderCreateManualPayment")
{
    public OrderCreateManualPaymentQueryBuilder AddArgumentAmount(MoneyInput? amount)
    {
        AddArgument("amount", amount);
        return this;
    }

    public OrderCreateManualPaymentQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public OrderCreateManualPaymentQueryBuilder AddArgumentPaymentMethodName(string? paymentMethodName)
    {
        AddArgument("paymentMethodName", paymentMethodName);
        return this;
    }

    public OrderCreateManualPaymentQueryBuilder AddArgumentProcessedAt(DateTime? processedAt)
    {
        AddArgument("processedAt", processedAt);
        return this;
    }
}