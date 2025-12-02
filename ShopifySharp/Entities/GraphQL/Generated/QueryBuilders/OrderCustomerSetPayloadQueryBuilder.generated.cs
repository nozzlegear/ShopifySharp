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

public class OrderCustomerSetPayloadQueryBuilder() : GraphQueryBuilder<OrderCustomerSetPayload>("orderCustomerSetPayload")
{
    public OrderCustomerSetPayloadQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public OrderCustomerSetPayloadQueryBuilder AddFieldUserErrors(Func<OrderCustomerSetUserErrorQueryBuilder, OrderCustomerSetUserErrorQueryBuilder> build)
    {
        AddField<OrderCustomerSetUserError, OrderCustomerSetUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}