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

public class OrderEditUpdateShippingLinePayloadQueryBuilder() : GraphQueryBuilder<OrderEditUpdateShippingLinePayload>("orderEditUpdateShippingLinePayload")
{
    public OrderEditUpdateShippingLinePayloadQueryBuilder AddFieldCalculatedOrder(Func<CalculatedOrderQueryBuilder, CalculatedOrderQueryBuilder> build)
    {
        AddField<CalculatedOrder, CalculatedOrderQueryBuilder>("calculatedOrder", build);
        return this;
    }

    public OrderEditUpdateShippingLinePayloadQueryBuilder AddFieldUserErrors(Func<OrderEditUpdateShippingLineUserErrorQueryBuilder, OrderEditUpdateShippingLineUserErrorQueryBuilder> build)
    {
        AddField<OrderEditUpdateShippingLineUserError, OrderEditUpdateShippingLineUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}