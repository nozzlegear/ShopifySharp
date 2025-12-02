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

public class OrderStagedChangeDecrementItemQueryBuilder() : GraphQueryBuilder<OrderStagedChangeDecrementItem>("orderStagedChangeDecrementItem")
{
    public OrderStagedChangeDecrementItemQueryBuilder AddFieldDelta()
    {
        AddField("delta");
        return this;
    }

    public OrderStagedChangeDecrementItemQueryBuilder AddFieldLineItem(Func<LineItemQueryBuilder, LineItemQueryBuilder> build)
    {
        AddField<LineItem, LineItemQueryBuilder>("lineItem", build);
        return this;
    }

    public OrderStagedChangeDecrementItemQueryBuilder AddFieldRestock()
    {
        AddField("restock");
        return this;
    }
}