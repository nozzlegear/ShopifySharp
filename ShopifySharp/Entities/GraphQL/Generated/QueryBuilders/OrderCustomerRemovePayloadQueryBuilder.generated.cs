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

public class OrderCustomerRemovePayloadQueryBuilder() : GraphQueryBuilder<OrderCustomerRemovePayload>("orderCustomerRemovePayload")
{
    public OrderCustomerRemovePayloadQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public OrderCustomerRemovePayloadQueryBuilder AddFieldUserErrors(Func<OrderCustomerRemoveUserErrorQueryBuilder, OrderCustomerRemoveUserErrorQueryBuilder> build)
    {
        AddField<OrderCustomerRemoveUserError, OrderCustomerRemoveUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}