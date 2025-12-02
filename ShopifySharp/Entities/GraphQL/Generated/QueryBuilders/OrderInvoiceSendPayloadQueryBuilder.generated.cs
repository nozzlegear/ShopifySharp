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

public class OrderInvoiceSendPayloadQueryBuilder() : GraphQueryBuilder<OrderInvoiceSendPayload>("orderInvoiceSendPayload")
{
    public OrderInvoiceSendPayloadQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public OrderInvoiceSendPayloadQueryBuilder AddFieldUserErrors(Func<OrderInvoiceSendUserErrorQueryBuilder, OrderInvoiceSendUserErrorQueryBuilder> build)
    {
        AddField<OrderInvoiceSendUserError, OrderInvoiceSendUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}