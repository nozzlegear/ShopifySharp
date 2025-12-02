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

public class OrderCapturePayloadQueryBuilder() : GraphQueryBuilder<OrderCapturePayload>("orderCapturePayload")
{
    public OrderCapturePayloadQueryBuilder AddFieldTransaction(Func<OrderTransactionQueryBuilder, OrderTransactionQueryBuilder> build)
    {
        AddField<OrderTransaction, OrderTransactionQueryBuilder>("transaction", build);
        return this;
    }

    public OrderCapturePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}