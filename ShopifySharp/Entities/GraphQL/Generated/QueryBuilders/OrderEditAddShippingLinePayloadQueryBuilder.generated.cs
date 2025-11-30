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

public class OrderEditAddShippingLinePayloadQueryBuilder() : GraphQueryBuilder<OrderEditAddShippingLinePayload>("orderEditAddShippingLinePayload")
{
    public OrderEditAddShippingLinePayloadQueryBuilder AddFieldCalculatedOrder(Func<CalculatedOrderQueryBuilder, CalculatedOrderQueryBuilder> build)
    {
        AddField<CalculatedOrder, CalculatedOrderQueryBuilder>("calculatedOrder", build);
        return this;
    }

    public OrderEditAddShippingLinePayloadQueryBuilder AddFieldCalculatedShippingLine(Func<CalculatedShippingLineQueryBuilder, CalculatedShippingLineQueryBuilder> build)
    {
        AddField<CalculatedShippingLine, CalculatedShippingLineQueryBuilder>("calculatedShippingLine", build);
        return this;
    }

    public OrderEditAddShippingLinePayloadQueryBuilder AddFieldUserErrors(Func<OrderEditAddShippingLineUserErrorQueryBuilder, OrderEditAddShippingLineUserErrorQueryBuilder> build)
    {
        AddField<OrderEditAddShippingLineUserError, OrderEditAddShippingLineUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}