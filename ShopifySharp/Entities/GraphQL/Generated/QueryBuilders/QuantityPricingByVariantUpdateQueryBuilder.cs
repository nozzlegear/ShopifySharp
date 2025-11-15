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

public class QuantityPricingByVariantUpdateQueryBuilder() : GraphQueryBuilder<QuantityPricingByVariantUpdatePayload>("query quantityPricingByVariantUpdate")
{
    public QuantityPricingByVariantUpdateQueryBuilder AddArgumentInput(QuantityPricingByVariantUpdateInput? input)
    {
        AddArgument("input", input);
        return this;
    }

    public QuantityPricingByVariantUpdateQueryBuilder AddArgumentPriceListId(string? priceListId)
    {
        AddArgument("priceListId", priceListId);
        return this;
    }
}