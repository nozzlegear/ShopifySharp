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

public class DiscountAmountQueryBuilder() : GraphQueryBuilder<DiscountAmount>("query discountAmount")
{
    public DiscountAmountQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public DiscountAmountQueryBuilder AddFieldAppliesOnEachItem()
    {
        AddField("appliesOnEachItem");
        return this;
    }
}