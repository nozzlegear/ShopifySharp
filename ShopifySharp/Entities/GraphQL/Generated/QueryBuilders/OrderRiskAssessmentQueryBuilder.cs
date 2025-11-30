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

public class OrderRiskAssessmentQueryBuilder() : GraphQueryBuilder<OrderRiskAssessment>("query orderRiskAssessment")
{
    public OrderRiskAssessmentQueryBuilder AddFieldFacts()
    {
        AddField("facts");
        return this;
    }

    public OrderRiskAssessmentQueryBuilder AddFieldProvider()
    {
        AddField("provider");
        return this;
    }

    public OrderRiskAssessmentQueryBuilder AddFieldRiskLevel()
    {
        AddField("riskLevel");
        return this;
    }
}