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

public class DiscountAutomaticBasicUpdateQueryBuilder() : GraphQueryBuilder<DiscountAutomaticBasicUpdatePayload>("query discountAutomaticBasicUpdate")
{
    public DiscountAutomaticBasicUpdateQueryBuilder AddArgumentAutomaticBasicDiscount(DiscountAutomaticBasicInput? automaticBasicDiscount)
    {
        AddArgument("automaticBasicDiscount", automaticBasicDiscount);
        return this;
    }

    public DiscountAutomaticBasicUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}