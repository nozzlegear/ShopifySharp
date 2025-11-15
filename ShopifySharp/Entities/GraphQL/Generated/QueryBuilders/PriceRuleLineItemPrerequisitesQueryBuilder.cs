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

public class PriceRuleLineItemPrerequisitesQueryBuilder() : GraphQueryBuilder<PriceRuleLineItemPrerequisites>("query priceRuleLineItemPrerequisites")
{
    public PriceRuleLineItemPrerequisitesQueryBuilder AddFieldCollections()
    {
        AddField("collections");
        return this;
    }

    public PriceRuleLineItemPrerequisitesQueryBuilder AddFieldProducts()
    {
        AddField("products");
        return this;
    }

    public PriceRuleLineItemPrerequisitesQueryBuilder AddFieldProductVariants()
    {
        AddField("productVariants");
        return this;
    }
}