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

public class OrderStagedChangeAddCustomItemQueryBuilder() : GraphQueryBuilder<OrderStagedChangeAddCustomItem>("orderStagedChangeAddCustomItem")
{
    public OrderStagedChangeAddCustomItemQueryBuilder AddFieldOriginalUnitPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("originalUnitPrice", build);
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