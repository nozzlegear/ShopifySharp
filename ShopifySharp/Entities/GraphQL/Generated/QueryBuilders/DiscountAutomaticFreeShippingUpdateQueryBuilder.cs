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

public class DiscountAutomaticFreeShippingUpdateQueryBuilder() : GraphQueryBuilder<DiscountAutomaticFreeShippingUpdatePayload>("query discountAutomaticFreeShippingUpdate")
{
    public DiscountAutomaticFreeShippingUpdateQueryBuilder AddArgumentFreeShippingAutomaticDiscount(DiscountAutomaticFreeShippingInput? freeShippingAutomaticDiscount)
    {
        AddArgument("freeShippingAutomaticDiscount", freeShippingAutomaticDiscount);
        return this;
    }

    public DiscountAutomaticFreeShippingUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}