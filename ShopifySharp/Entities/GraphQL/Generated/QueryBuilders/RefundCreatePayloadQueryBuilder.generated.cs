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

public class RefundCreatePayloadQueryBuilder() : GraphQueryBuilder<RefundCreatePayload>("refundCreatePayload")
{
    public RefundCreatePayloadQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public RefundCreatePayloadQueryBuilder AddFieldRefund(Func<RefundQueryBuilder, RefundQueryBuilder> build)
    {
        AddField<Refund, RefundQueryBuilder>("refund", build);
        return this;
    }

    public RefundCreatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}