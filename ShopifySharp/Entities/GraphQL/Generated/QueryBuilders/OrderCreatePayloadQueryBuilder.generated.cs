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

public class OrderCreatePayloadQueryBuilder() : GraphQueryBuilder<OrderCreatePayload>("orderCreatePayload")
{
    public OrderCreatePayloadQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public OrderCreatePayloadQueryBuilder AddFieldUserErrors(Func<OrderCreateUserErrorQueryBuilder, OrderCreateUserErrorQueryBuilder> build)
    {
        AddField<OrderCreateUserError, OrderCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}