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

public class OrderStagedChangeAddShippingLineQueryBuilder() : GraphQueryBuilder<OrderStagedChangeAddShippingLine>("orderStagedChangeAddShippingLine")
{
    public OrderStagedChangeAddShippingLineQueryBuilder AddFieldPhone()
    {
        AddField("phone");
        return this;
    }

    public OrderStagedChangeAddShippingLineQueryBuilder AddFieldPresentmentTitle()
    {
        AddField("presentmentTitle");
        return this;
    }

    public OrderStagedChangeAddShippingLineQueryBuilder AddFieldPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("price", build);
        return this;
    }

    public OrderStagedChangeAddShippingLineQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}