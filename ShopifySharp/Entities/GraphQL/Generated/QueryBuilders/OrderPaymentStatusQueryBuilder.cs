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

public class OrderPaymentStatusQueryBuilder() : GraphQueryBuilder<OrderPaymentStatus>("query orderPaymentStatus")
{
    public OrderPaymentStatusQueryBuilder AddArgumentOrderId(string? orderId)
    {
        AddArgument("orderId", orderId);
        return this;
    }

    public OrderPaymentStatusQueryBuilder AddArgumentPaymentReferenceId(string? paymentReferenceId)
    {
        AddArgument("paymentReferenceId", paymentReferenceId);
        return this;
    }
}