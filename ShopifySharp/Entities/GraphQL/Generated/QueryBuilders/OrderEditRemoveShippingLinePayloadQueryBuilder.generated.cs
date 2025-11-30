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

public class OrderEditRemoveShippingLinePayloadQueryBuilder() : GraphQueryBuilder<OrderEditRemoveShippingLinePayload>("orderEditRemoveShippingLinePayload")
{
    public OrderEditRemoveShippingLinePayloadQueryBuilder AddFieldCalculatedOrder(Func<CalculatedOrderQueryBuilder, CalculatedOrderQueryBuilder> build)
    {
        AddField<CalculatedOrder, CalculatedOrderQueryBuilder>("calculatedOrder", build);
        return this;
    }

    public OrderEditRemoveShippingLinePayloadQueryBuilder AddFieldUserErrors(Func<OrderEditRemoveShippingLineUserErrorQueryBuilder, OrderEditRemoveShippingLineUserErrorQueryBuilder> build)
    {
        AddField<OrderEditRemoveShippingLineUserError, OrderEditRemoveShippingLineUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}