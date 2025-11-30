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

public class OrderStagedChangeAddShippingLineQueryBuilder() : GraphQueryBuilder<OrderStagedChangeAddShippingLine>("query orderStagedChangeAddShippingLine")
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

    public OrderStagedChangeAddShippingLineQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public OrderStagedChangeAddShippingLineQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}