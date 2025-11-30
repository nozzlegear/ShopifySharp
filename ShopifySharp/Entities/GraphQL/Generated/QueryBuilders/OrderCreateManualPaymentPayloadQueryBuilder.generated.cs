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

public class OrderCreateManualPaymentPayloadQueryBuilder() : GraphQueryBuilder<OrderCreateManualPaymentPayload>("orderCreateManualPaymentPayload")
{
    public OrderCreateManualPaymentPayloadQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public OrderCreateManualPaymentPayloadQueryBuilder AddFieldUserErrors(Func<OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder, OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder> build)
    {
        AddField<OrderCreateManualPaymentOrderCreateManualPaymentError, OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder>("userErrors", build);
        return this;
    }
}