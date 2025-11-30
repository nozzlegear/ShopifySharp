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

public class OrderStagedChangeIncrementItemQueryBuilder() : GraphQueryBuilder<OrderStagedChangeIncrementItem>("orderStagedChangeIncrementItem")
{
    public OrderStagedChangeIncrementItemQueryBuilder AddFieldDelta()
    {
        AddField("delta");
        return this;
    }

    public OrderStagedChangeIncrementItemQueryBuilder AddFieldLineItem(Func<LineItemQueryBuilder, LineItemQueryBuilder> build)
    {
        AddField<LineItem, LineItemQueryBuilder>("lineItem", build);
        return this;
    }
}