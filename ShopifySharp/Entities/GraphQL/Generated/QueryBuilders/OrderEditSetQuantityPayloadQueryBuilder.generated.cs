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

public class OrderEditSetQuantityPayloadQueryBuilder() : GraphQueryBuilder<OrderEditSetQuantityPayload>("orderEditSetQuantityPayload")
{
    public OrderEditSetQuantityPayloadQueryBuilder AddFieldCalculatedLineItem(Func<CalculatedLineItemQueryBuilder, CalculatedLineItemQueryBuilder> build)
    {
        AddField<CalculatedLineItem, CalculatedLineItemQueryBuilder>("calculatedLineItem", build);
        return this;
    }

    public OrderEditSetQuantityPayloadQueryBuilder AddFieldCalculatedOrder(Func<CalculatedOrderQueryBuilder, CalculatedOrderQueryBuilder> build)
    {
        AddField<CalculatedOrder, CalculatedOrderQueryBuilder>("calculatedOrder", build);
        return this;
    }

    public OrderEditSetQuantityPayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}