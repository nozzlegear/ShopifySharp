#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class PriceRuleValidityPeriodQueryBuilder() : GraphQueryBuilder<PriceRuleValidityPeriod>("priceRuleValidityPeriod")
{
    public PriceRuleValidityPeriodQueryBuilder AddFieldEnd()
    {
        AddField("end");
        return this;
    }

    public PriceRuleValidityPeriodQueryBuilder AddFieldStart()
    {
        AddField("start");
        return this;
    }
}