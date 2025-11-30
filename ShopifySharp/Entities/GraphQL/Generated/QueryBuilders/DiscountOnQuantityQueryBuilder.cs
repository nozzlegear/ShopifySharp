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

public class DiscountOnQuantityQueryBuilder() : GraphQueryBuilder<DiscountOnQuantity>("query discountOnQuantity")
{
    public DiscountOnQuantityQueryBuilder AddFieldEffect()
    {
        AddField("effect");
        return this;
    }

    public DiscountOnQuantityQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }
}