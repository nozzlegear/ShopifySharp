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

public class OrderEditAddCustomItemPayloadQueryBuilder() : GraphQueryBuilder<OrderEditAddCustomItemPayload>("orderEditAddCustomItemPayload")
{
    public OrderEditAddCustomItemPayloadQueryBuilder AddFieldCalculatedLineItem(Func<CalculatedLineItemQueryBuilder, CalculatedLineItemQueryBuilder> build)
    {
        AddField<CalculatedLineItem, CalculatedLineItemQueryBuilder>("calculatedLineItem", build);
        return this;
    }

    public OrderEditAddCustomItemPayloadQueryBuilder AddFieldCalculatedOrder(Func<CalculatedOrderQueryBuilder, CalculatedOrderQueryBuilder> build)
    {
        AddField<CalculatedOrder, CalculatedOrderQueryBuilder>("calculatedOrder", build);
        return this;
    }

    public OrderEditAddCustomItemPayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}