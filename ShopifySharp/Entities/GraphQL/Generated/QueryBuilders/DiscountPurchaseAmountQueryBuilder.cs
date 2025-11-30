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

public class DiscountPurchaseAmountQueryBuilder() : GraphQueryBuilder<DiscountPurchaseAmount>("query discountPurchaseAmount")
{
    public DiscountPurchaseAmountQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }
}