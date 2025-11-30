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

public class MarketPriceInclusionsQueryBuilder() : GraphQueryBuilder<MarketPriceInclusions>("query marketPriceInclusions")
{
    public MarketPriceInclusionsQueryBuilder AddFieldInclusiveDutiesPricingStrategy()
    {
        AddField("inclusiveDutiesPricingStrategy");
        return this;
    }

    public MarketPriceInclusionsQueryBuilder AddFieldInclusiveTaxPricingStrategy()
    {
        AddField("inclusiveTaxPricingStrategy");
        return this;
    }
}