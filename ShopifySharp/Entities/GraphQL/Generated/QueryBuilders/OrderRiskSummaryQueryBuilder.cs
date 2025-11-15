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

public class OrderRiskSummaryQueryBuilder() : GraphQueryBuilder<OrderRiskSummary>("query orderRiskSummary")
{
    public OrderRiskSummaryQueryBuilder AddFieldAssessments()
    {
        AddField("assessments");
        return this;
    }

    public OrderRiskSummaryQueryBuilder AddFieldRecommendation()
    {
        AddField("recommendation");
        return this;
    }
}