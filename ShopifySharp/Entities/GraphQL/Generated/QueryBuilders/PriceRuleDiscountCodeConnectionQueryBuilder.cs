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

public class PriceRuleDiscountCodeConnectionQueryBuilder() : GraphQueryBuilder<PriceRuleDiscountCodeConnection>("query priceRuleDiscountCodeConnection")
{
    public PriceRuleDiscountCodeConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public PriceRuleDiscountCodeConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public PriceRuleDiscountCodeConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}