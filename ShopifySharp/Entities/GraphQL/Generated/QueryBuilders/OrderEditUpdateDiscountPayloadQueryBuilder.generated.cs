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

public class OrderEditUpdateDiscountPayloadQueryBuilder() : GraphQueryBuilder<OrderEditUpdateDiscountPayload>("orderEditUpdateDiscountPayload")
{
    public OrderEditUpdateDiscountPayloadQueryBuilder AddFieldCalculatedOrder(Func<CalculatedOrderQueryBuilder, CalculatedOrderQueryBuilder> build)
    {
        AddField<CalculatedOrder, CalculatedOrderQueryBuilder>("calculatedOrder", build);
        return this;
    }

    public OrderEditUpdateDiscountPayloadQueryBuilder AddFieldUserErrors(Func<OrderEditUpdateDiscountUserErrorQueryBuilder, OrderEditUpdateDiscountUserErrorQueryBuilder> build)
    {
        AddField<OrderEditUpdateDiscountUserError, OrderEditUpdateDiscountUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}