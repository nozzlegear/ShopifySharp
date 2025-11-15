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

public class DiscountPercentageQueryBuilder() : GraphQueryBuilder<DiscountPercentage>("query discountPercentage")
{
    public DiscountPercentageQueryBuilder AddFieldPercentage()
    {
        AddField("percentage");
        return this;
    }
}