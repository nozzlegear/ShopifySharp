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

public class PriceRuleItemEntitlementsQueryBuilder() : GraphQueryBuilder<PriceRuleItemEntitlements>("query priceRuleItemEntitlements")
{
    public PriceRuleItemEntitlementsQueryBuilder AddFieldCollections()
    {
        AddField("collections");
        return this;
    }

    public PriceRuleItemEntitlementsQueryBuilder AddFieldProducts()
    {
        AddField("products");
        return this;
    }

    public PriceRuleItemEntitlementsQueryBuilder AddFieldProductVariants()
    {
        AddField("productVariants");
        return this;
    }

    public PriceRuleItemEntitlementsQueryBuilder AddFieldTargetAllLineItems()
    {
        AddField("targetAllLineItems");
        return this;
    }
}