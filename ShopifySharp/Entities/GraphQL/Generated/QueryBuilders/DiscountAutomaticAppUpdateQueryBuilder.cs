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

public class DiscountAutomaticAppUpdateQueryBuilder() : GraphQueryBuilder<DiscountAutomaticAppUpdatePayload>("query discountAutomaticAppUpdate")
{
    public DiscountAutomaticAppUpdateQueryBuilder AddArgumentAutomaticAppDiscount(DiscountAutomaticAppInput? automaticAppDiscount)
    {
        AddArgument("automaticAppDiscount", automaticAppDiscount);
        return this;
    }

    public DiscountAutomaticAppUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}