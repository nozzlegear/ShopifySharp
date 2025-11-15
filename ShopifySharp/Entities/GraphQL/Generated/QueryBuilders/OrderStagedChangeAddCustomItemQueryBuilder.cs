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

public class OrderStagedChangeAddCustomItemQueryBuilder() : GraphQueryBuilder<OrderStagedChangeAddCustomItem>("query orderStagedChangeAddCustomItem")
{
    public OrderStagedChangeAddCustomItemQueryBuilder AddFieldOriginalUnitPrice()
    {
        AddField("originalUnitPrice");
        return this;
    }

    public OrderStagedChangeAddCustomItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public OrderStagedChangeAddCustomItemQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}