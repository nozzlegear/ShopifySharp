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

public class RiskFactQueryBuilder() : GraphQueryBuilder<RiskFact>("riskFact")
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