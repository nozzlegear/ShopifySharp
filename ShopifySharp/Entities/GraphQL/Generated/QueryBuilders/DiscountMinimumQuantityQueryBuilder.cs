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

public class DiscountMinimumQuantityQueryBuilder() : GraphQueryBuilder<DiscountMinimumQuantity>("query discountMinimumQuantity")
{
    public DiscountMinimumQuantityQueryBuilder AddFieldGreaterThanOrEqualToQuantity()
    {
        AddField("greaterThanOrEqualToQuantity");
        return this;
    }
}