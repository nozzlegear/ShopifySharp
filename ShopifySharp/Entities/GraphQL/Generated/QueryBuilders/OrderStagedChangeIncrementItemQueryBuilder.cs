#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class OrderStagedChangeIncrementItemQueryBuilder() : GraphQueryBuilder<OrderStagedChangeIncrementItem>("query orderStagedChangeIncrementItem")
{
    public OrderStagedChangeIncrementItemQueryBuilder AddFieldDelta()
    {
        AddField("delta");
        return this;
    }

    public OrderStagedChangeIncrementItemQueryBuilder AddFieldLineItem()
    {
        AddField("lineItem");
        return this;
    }
}