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

public class DiscountCombinesWithQueryBuilder() : GraphQueryBuilder<DiscountCombinesWith>("query discountCombinesWith")
{
    public DiscountCombinesWithQueryBuilder AddFieldOrderDiscounts()
    {
        AddField("orderDiscounts");
        return this;
    }

    public DiscountCombinesWithQueryBuilder AddFieldProductDiscounts()
    {
        AddField("productDiscounts");
        return this;
    }

    public DiscountCombinesWithQueryBuilder AddFieldShippingDiscounts()
    {
        AddField("shippingDiscounts");
        return this;
    }
}