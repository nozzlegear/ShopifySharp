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

public class QuantityRulesDeleteQueryBuilder() : GraphQueryBuilder<QuantityRulesDeletePayload>("query quantityRulesDelete")
{
    public QuantityRulesDeleteQueryBuilder AddArgumentPriceListId(string? priceListId)
    {
        AddArgument("priceListId", priceListId);
        return this;
    }

    public QuantityRulesDeleteQueryBuilder AddArgumentVariantIds(ICollection<string>? variantIds)
    {
        AddArgument("variantIds", variantIds);
        return this;
    }
}