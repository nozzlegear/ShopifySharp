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

public class OrderRiskAssessmentQueryBuilder() : GraphQueryBuilder<OrderRiskAssessment>("orderRiskAssessment")
{
    public OrderRiskAssessmentQueryBuilder AddFieldFacts(Func<RiskFactQueryBuilder, RiskFactQueryBuilder> build)
    {
        AddField<RiskFact, RiskFactQueryBuilder>("facts", build);
        return this;
    }

    public OrderRiskAssessmentQueryBuilder AddFieldProvider(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("provider", build);
        return this;
    }

    public OrderRiskAssessmentQueryBuilder AddFieldRiskLevel()
    {
        AddField("riskLevel");
        return this;
    }
}