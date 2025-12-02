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

public class OrderEditRemoveDiscountPayloadQueryBuilder() : GraphQueryBuilder<OrderEditRemoveDiscountPayload>("orderEditRemoveDiscountPayload")
{
    public OrderEditRemoveDiscountPayloadQueryBuilder AddFieldCalculatedOrder(Func<CalculatedOrderQueryBuilder, CalculatedOrderQueryBuilder> build)
    {
        AddField<CalculatedOrder, CalculatedOrderQueryBuilder>("calculatedOrder", build);
        return this;
    }

    public OrderEditRemoveDiscountPayloadQueryBuilder AddFieldUserErrors(Func<OrderEditRemoveDiscountUserErrorQueryBuilder, OrderEditRemoveDiscountUserErrorQueryBuilder> build)
    {
        AddField<OrderEditRemoveDiscountUserError, OrderEditRemoveDiscountUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}