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

public class PriceRuleShippingLineEntitlementsQueryBuilder() : GraphQueryBuilder<PriceRuleShippingLineEntitlements>("query priceRuleShippingLineEntitlements")
{
    public PriceRuleShippingLineEntitlementsQueryBuilder AddFieldCountryCodes()
    {
        AddField("countryCodes");
        return this;
    }

    public PriceRuleShippingLineEntitlementsQueryBuilder AddFieldIncludeRestOfWorld()
    {
        AddField("includeRestOfWorld");
        return this;
    }

    public PriceRuleShippingLineEntitlementsQueryBuilder AddFieldTargetAllShippingLines()
    {
        AddField("targetAllShippingLines");
        return this;
    }
}