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

public class OrderStagedChangeAddLineItemDiscountQueryBuilder() : GraphQueryBuilder<OrderStagedChangeAddLineItemDiscount>("query orderStagedChangeAddLineItemDiscount")
{
    public OrderStagedChangeAddLineItemDiscountQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public OrderStagedChangeAddLineItemDiscountQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public OrderStagedChangeAddLineItemDiscountQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}