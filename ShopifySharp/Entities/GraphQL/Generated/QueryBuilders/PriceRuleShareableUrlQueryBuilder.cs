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

public class PriceRuleShareableUrlQueryBuilder() : GraphQueryBuilder<PriceRuleShareableUrl>("query priceRuleShareableUrl")
{
    public PriceRuleShareableUrlQueryBuilder AddFieldTargetItemImage()
    {
        AddField("targetItemImage");
        return this;
    }

    public PriceRuleShareableUrlQueryBuilder AddFieldTargetType()
    {
        AddField("targetType");
        return this;
    }

    public PriceRuleShareableUrlQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public PriceRuleShareableUrlQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}