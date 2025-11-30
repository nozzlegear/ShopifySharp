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

public class RiskFactQueryBuilder() : GraphQueryBuilder<RiskFact>("query riskFact")
{
    public RiskFactQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public RiskFactQueryBuilder AddFieldSentiment()
    {
        AddField("sentiment");
        return this;
    }
}